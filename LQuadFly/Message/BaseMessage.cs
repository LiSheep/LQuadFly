using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQuadFly.Message
{
    public abstract class BaseMessage
    {
        public static byte type;
        protected static byte HEAD = 255;

        //计算校验和
        public static byte getSum(byte[] data)
        {
            byte sum = data[1];
            for (int i = 2; i < data.Count(); i++)
            {
                sum += data[i];
            }
            return sum;
        }

        public BaseMessage(byte type)
        {
            BaseMessage.type = type;
        }
        
        //获取要输出的数据
        public abstract byte[] getOutData();

        //处理得到的数据
        public abstract byte[] dealData(byte[] data);
    }
}
