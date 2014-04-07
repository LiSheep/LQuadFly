using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQuadFly.Common;

namespace LQuadFly.Message
{
    public class PIDReadMessage : BaseMessage
    {
        List<byte> data = new List<byte>();

        public PIDReadMessage()
            : base(Dictionary.PROTOCOL_ROM_R)
        { }

        public override byte[] getOutData()
        {
            byte[] tmp = new byte[2];
            tmp[0] = type;
            tmp[1] = 10; //随便一个值
            byte size = (byte)(tmp.Length + 1);
            data.Add(HEAD);
            data.Add(size);
            data.AddRange(tmp);
            data.Add(getSum(tmp));

            return data.ToArray();
        }

        public override byte[] dealData(byte[] data)
        {
            List<byte> d = data.ToList();
            d.RemoveAt(0);
            return d.ToArray();
        }
    }
}
