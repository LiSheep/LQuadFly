using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQuadFly.Serial;
using LQuadFly.Message;
using System.Threading;
using LQuadFly.Common;

namespace LQuadFly
{
    public partial class LQuadFlyMainView : Form
    {
        private string portnum = "";    //当前打开的串口
        public delegate void MyInvoke();
        List<byte> data = null;

        public LQuadFlyMainView()
        {
            InitializeComponent();
            LoadPorts();
        }

        //后台监听串口
        public void WatchSerial()
        {
            Thread thread = new Thread(SerialRead);
            thread.IsBackground = true;
            thread.Start();
            
        }

        public void SerialRead()
        {
            
            while (true)
            {
                Invoke(new MyInvoke(updateUI));
                if (SerialOperation.isOpen(this.portnum))
                {
                    data = SerialOperation.ReadData();
                }
            }
        }

        public void updateUI()
        {
            if (data == null)
                return;
            int i = data[0];
            StringBuilder builder = new StringBuilder();
            foreach (var d in data)
            {
                builder.Append(d + "  ");
            }
            builder.Append("\r\n");
            this.txt_serial.Text += builder.ToString();
            
            switch (i)
            {
                case Dictionary.PROTOCOL_SERVO:
                    ServoMessage msg = new ServoMessage();
                    byte []res = msg.dealData(data.ToArray());
                    //this.num_preleft.Value = res[0];
                    //this.num_preright.Value = res[0];
                    //this.num_backleft.Value = res[0];
                    //this.num_backright.Value = res[0];
                    break;
                case Dictionary.PROTOCOL_ROM_R:
                    PIDReadMessage prmsg = new PIDReadMessage();
                    byte[] prres = prmsg.dealData(data.ToArray());
                    float[] pid = new float[6];
                    for (int c = 0; c < 24; c+=4)
                    {
                        pid[c/4] = BitConverter.ToSingle(prres, c);
                        
                    }
                    this.txt_rp.Text = pid[0].ToString();
                    this.txt_ri.Text = pid[1].ToString();
                    this.txt_rd.Text = pid[2].ToString();

                    this.txt_pp.Text = pid[3].ToString();
                    this.txt_pi.Text = pid[4].ToString();
                    this.txt_pd.Text = pid[5].ToString();

                    break;
                case Dictionary.PROTOCOL_ROM_W:
                    this.txt_serial.Text += "PID写入成功\r\n";
                    break;
            }
            data = null;
        }


        //加载串口信息
        public void LoadPorts()
        {
            this.menu_serial.DropDownItems.Clear(); //清空原有串口
            this.menu_serial.DropDownItems.Add(item_reload);
            string[] ports = SerialOperation.GetPorts();
            List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();
            foreach (string p in ports)
            {
                ToolStripMenuItem child = new ToolStripMenuItem(p);
                child.Click += new EventHandler(child_Click);
                items.Add(child);
            }

            this.menu_serial.DropDownItems.AddRange(items.ToArray());
        }

        //把所有选中状态清空
        public void unCheckAllItems()
        {
            foreach (ToolStripMenuItem i in this.menu_serial.DropDownItems)
            {
                i.CheckState = CheckState.Unchecked;
            }
        }

        //点击串口
        void child_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (!SerialOperation.isOpen(item.Text)) //串口没有打开，则打开
            {
                if (SerialOperation.Open(item.Text, 9600))
                {
                    item.CheckState = CheckState.Checked;
                    this.portnum = item.Text;
                    WatchSerial();
                }
                else
                {
                    MessageBox.Show("打开失败,请检查串口");
                }
            }
            else //已经打开，则关闭串口
            {
                item.CheckState = CheckState.Unchecked;
                this.portnum = "";
                SerialOperation.Close();
            }

        }

        private void item_reload_Click(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void btn_tozero_Click(object sender, EventArgs e)
        {
            if (SerialOperation.isOpen(this.portnum))
            {
                PowerMessage msg = new PowerMessage();
                msg.setData(false);
                SerialOperation.WriteData(msg.getOutData());
            }
        }

        private void btn_readpid_Click(object sender, EventArgs e)
        {
            if (SerialOperation.isOpen(this.portnum))
            {
                PIDReadMessage msg = new PIDReadMessage();
                SerialOperation.WriteData(msg.getOutData());

            }
        }

        private void btn_writepid_Click(object sender, EventArgs e)
        {
            if (SerialOperation.isOpen(this.portnum))
            {
                PIDWriteMessage msg = new PIDWriteMessage();
                msg.setData(this.txt_rp.Text, this.txt_ri.Text, this.txt_rd.Text, this.txt_pp.Text, this.txt_pi.Text, this.txt_pd.Text);
                SerialOperation.WriteData(msg.getOutData());

            }
        }

        private void numericPower_ValueChanged(object sender, EventArgs e)
        {
            if (SerialOperation.isOpen(this.portnum))
            {
                ServoMessage msg = new ServoMessage();
                decimal val = this.numericPower.Value;
                decimal[] datas = { val, val, val, val };
                msg.setData(datas);
                SerialOperation.WriteData(HandleMessage.getDataToWrite(msg));
            }
        }


    }
}
