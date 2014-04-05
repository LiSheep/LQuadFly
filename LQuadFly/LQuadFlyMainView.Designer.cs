namespace LQuadFly
{
    partial class LQuadFlyMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericPower = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tozero = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_readpid = new System.Windows.Forms.Button();
            this.btn_writepid = new System.Windows.Forms.Button();
            this.txt_pi = new System.Windows.Forms.TextBox();
            this.txt_pd = new System.Windows.Forms.TextBox();
            this.txt_pp = new System.Windows.Forms.TextBox();
            this.txt_ri = new System.Windows.Forms.TextBox();
            this.txt_rd = new System.Windows.Forms.TextBox();
            this.txt_rp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_high = new System.Windows.Forms.TextBox();
            this.num_backleft = new System.Windows.Forms.NumericUpDown();
            this.num_preright = new System.Windows.Forms.NumericUpDown();
            this.num_backright = new System.Windows.Forms.NumericUpDown();
            this.num_preleft = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_serial = new System.Windows.Forms.ToolStripMenuItem();
            this.item_reload = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_backleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_backright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preleft)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericPower);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_tozero);
            this.groupBox1.Controls.Add(this.btn_left);
            this.groupBox1.Controls.Add(this.btn_right);
            this.groupBox1.Controls.Add(this.btn_down);
            this.groupBox1.Controls.Add(this.btn_up);
            this.groupBox1.Location = new System.Drawing.Point(28, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作板";
            // 
            // numericPower
            // 
            this.numericPower.Location = new System.Drawing.Point(85, 348);
            this.numericPower.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericPower.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numericPower.Name = "numericPower";
            this.numericPower.Size = new System.Drawing.Size(105, 21);
            this.numericPower.TabIndex = 6;
            this.numericPower.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numericPower.ValueChanged += new System.EventHandler(this.numericPower_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "油门";
            // 
            // btn_tozero
            // 
            this.btn_tozero.Location = new System.Drawing.Point(268, 382);
            this.btn_tozero.Name = "btn_tozero";
            this.btn_tozero.Size = new System.Drawing.Size(71, 36);
            this.btn_tozero.TabIndex = 4;
            this.btn_tozero.Text = "油门归0";
            this.btn_tozero.UseVisualStyleBackColor = true;
            this.btn_tozero.Click += new System.EventHandler(this.btn_tozero_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(34, 150);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(71, 42);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "左 ←";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(255, 150);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(71, 42);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "右 →";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(137, 236);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(71, 42);
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "后 ↓";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(137, 52);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(71, 42);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "前 ↑";
            this.btn_up.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_readpid);
            this.groupBox2.Controls.Add(this.btn_writepid);
            this.groupBox2.Controls.Add(this.txt_pi);
            this.groupBox2.Controls.Add(this.txt_pd);
            this.groupBox2.Controls.Add(this.txt_pp);
            this.groupBox2.Controls.Add(this.txt_ri);
            this.groupBox2.Controls.Add(this.txt_rd);
            this.groupBox2.Controls.Add(this.txt_rp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(500, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID设置";
            // 
            // btn_readpid
            // 
            this.btn_readpid.Location = new System.Drawing.Point(235, 147);
            this.btn_readpid.Name = "btn_readpid";
            this.btn_readpid.Size = new System.Drawing.Size(62, 22);
            this.btn_readpid.TabIndex = 9;
            this.btn_readpid.Text = "READ";
            this.btn_readpid.UseVisualStyleBackColor = true;
            this.btn_readpid.Click += new System.EventHandler(this.btn_readpid_Click);
            // 
            // btn_writepid
            // 
            this.btn_writepid.Location = new System.Drawing.Point(323, 147);
            this.btn_writepid.Name = "btn_writepid";
            this.btn_writepid.Size = new System.Drawing.Size(62, 22);
            this.btn_writepid.TabIndex = 8;
            this.btn_writepid.Text = "WRITE";
            this.btn_writepid.UseVisualStyleBackColor = true;
            this.btn_writepid.Click += new System.EventHandler(this.btn_writepid_Click);
            // 
            // txt_pi
            // 
            this.txt_pi.Location = new System.Drawing.Point(186, 103);
            this.txt_pi.Name = "txt_pi";
            this.txt_pi.Size = new System.Drawing.Size(64, 21);
            this.txt_pi.TabIndex = 7;
            this.txt_pi.Text = "0";
            // 
            // txt_pd
            // 
            this.txt_pd.Location = new System.Drawing.Point(285, 103);
            this.txt_pd.Name = "txt_pd";
            this.txt_pd.Size = new System.Drawing.Size(64, 21);
            this.txt_pd.TabIndex = 6;
            this.txt_pd.Text = "0";
            // 
            // txt_pp
            // 
            this.txt_pp.Location = new System.Drawing.Point(92, 103);
            this.txt_pp.Name = "txt_pp";
            this.txt_pp.Size = new System.Drawing.Size(64, 21);
            this.txt_pp.TabIndex = 5;
            this.txt_pp.Text = "0";
            // 
            // txt_ri
            // 
            this.txt_ri.Location = new System.Drawing.Point(186, 42);
            this.txt_ri.Name = "txt_ri";
            this.txt_ri.Size = new System.Drawing.Size(64, 21);
            this.txt_ri.TabIndex = 4;
            this.txt_ri.Text = "0";
            // 
            // txt_rd
            // 
            this.txt_rd.Location = new System.Drawing.Point(285, 42);
            this.txt_rd.Name = "txt_rd";
            this.txt_rd.Size = new System.Drawing.Size(64, 21);
            this.txt_rd.TabIndex = 3;
            this.txt_rd.Text = "0";
            // 
            // txt_rp
            // 
            this.txt_rp.Location = new System.Drawing.Point(92, 42);
            this.txt_rp.Name = "txt_rp";
            this.txt_rp.Size = new System.Drawing.Size(64, 21);
            this.txt_rp.TabIndex = 2;
            this.txt_rp.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PITCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROLL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_high);
            this.groupBox3.Controls.Add(this.num_backleft);
            this.groupBox3.Controls.Add(this.num_preright);
            this.groupBox3.Controls.Add(this.num_backright);
            this.groupBox3.Controls.Add(this.num_preleft);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(500, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 392);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "监控";
            // 
            // txt_high
            // 
            this.txt_high.Location = new System.Drawing.Point(128, 295);
            this.txt_high.Name = "txt_high";
            this.txt_high.ReadOnly = true;
            this.txt_high.Size = new System.Drawing.Size(113, 21);
            this.txt_high.TabIndex = 6;
            this.txt_high.Text = "0";
            // 
            // num_backleft
            // 
            this.num_backleft.Location = new System.Drawing.Point(128, 171);
            this.num_backleft.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_backleft.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.num_backleft.Name = "num_backleft";
            this.num_backleft.ReadOnly = true;
            this.num_backleft.Size = new System.Drawing.Size(74, 21);
            this.num_backleft.TabIndex = 5;
            this.num_backleft.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // num_preright
            // 
            this.num_preright.Location = new System.Drawing.Point(298, 52);
            this.num_preright.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_preright.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.num_preright.Name = "num_preright";
            this.num_preright.ReadOnly = true;
            this.num_preright.Size = new System.Drawing.Size(74, 21);
            this.num_preright.TabIndex = 4;
            this.num_preright.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // num_backright
            // 
            this.num_backright.Location = new System.Drawing.Point(298, 171);
            this.num_backright.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_backright.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.num_backright.Name = "num_backright";
            this.num_backright.ReadOnly = true;
            this.num_backright.Size = new System.Drawing.Size(74, 21);
            this.num_backright.TabIndex = 3;
            this.num_backright.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // num_preleft
            // 
            this.num_preleft.Location = new System.Drawing.Point(128, 52);
            this.num_preleft.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_preleft.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.num_preleft.Name = "num_preleft";
            this.num_preleft.ReadOnly = true;
            this.num_preleft.Size = new System.Drawing.Size(74, 21);
            this.num_preleft.TabIndex = 2;
            this.num_preleft.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前高度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "当前油门";
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(32, 542);
            this.txt_serial.Multiline = true;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(369, 108);
            this.txt_serial.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_serial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_serial
            // 
            this.menu_serial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_reload});
            this.menu_serial.Name = "menu_serial";
            this.menu_serial.Size = new System.Drawing.Size(44, 21);
            this.menu_serial.Text = "串口";
            // 
            // item_reload
            // 
            this.item_reload.Name = "item_reload";
            this.item_reload.Size = new System.Drawing.Size(124, 22);
            this.item_reload.Text = "重新加载";
            this.item_reload.Click += new System.EventHandler(this.item_reload_Click);
            // 
            // LQuadFlyMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(984, 673);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LQuadFlyMainView";
            this.Text = "小灰机控制台";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_backleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_backright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preleft)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ri;
        private System.Windows.Forms.TextBox txt_rd;
        private System.Windows.Forms.TextBox txt_rp;
        private System.Windows.Forms.TextBox txt_pi;
        private System.Windows.Forms.TextBox txt_pd;
        private System.Windows.Forms.TextBox txt_pp;
        private System.Windows.Forms.Button btn_readpid;
        private System.Windows.Forms.Button btn_writepid;
        private System.Windows.Forms.Button btn_tozero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_backleft;
        private System.Windows.Forms.NumericUpDown num_preright;
        private System.Windows.Forms.NumericUpDown num_backright;
        private System.Windows.Forms.NumericUpDown num_preleft;
        private System.Windows.Forms.TextBox txt_high;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_serial;
        private System.Windows.Forms.ToolStripMenuItem item_reload;
    }
}