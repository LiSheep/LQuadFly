using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace LQuadFly.Serial
{
    public static class SerialOperation
    {
        public static String portNum = "";
        private static SerialPort port = null;
        private static bool status;     //true 开， false 关

        public static bool Open(string portNum, int hz)
        {
            try{
                if (port != null)   //如果原先串口未关闭
                {
                    Close();
                }
                port = new SerialPort(portNum, hz);
                port.Open();
            }catch(Exception ex)
            {
                return false;
            }

            SerialOperation.portNum = portNum;
            status = true;
            return true;
        }

        

        public static void Close()
        {
            port.Close();
            status = false;
            port = null;
        }

        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public static int readPort()
        {
            int a = -1;
            try
            {
                a = port.ReadByte();
            }
            catch (Exception e)
            {
                port = null;
            }
            return a;
        }

        public static List<byte> ReadData()
        {
            List<byte> data = null;
            Thread.Sleep(30);
            if (status)
            {
                data = new List<byte>();
                int a;
                try
                {
                    a = readPort();
                }
                catch (Exception e)
                {
                    port = null;
                    return null;
                }
                while (a != 255)
                {
                    a = readPort();
                }
                int len = readPort();

                for (int i = 0; i < len; i++) //读取data
                {
                    byte d = Byte.Parse(readPort().ToString());

                    data.Add(d);
                }
 
                //校验
            }

            return data;
        }

        public static void WriteData(byte []data)
        {
            if (status)
            {
                port.Write(data, 0, data.Length);
            }
        }

        public static bool isOpen(string portNum)
        {
            return (portNum == SerialOperation.portNum && status);
        }

    }
}
