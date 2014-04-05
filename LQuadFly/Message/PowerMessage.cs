using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQuadFly.Common;

namespace LQuadFly.Message
{
    public class PowerMessage : BaseMessage
    {
        List<byte> data = new List<byte>();
        byte d = 0;

        public PowerMessage()
            : base(Dictionary.SWITCH_POWER)
        { }
        public override byte[] getOutData()
        {
            byte sum = getSum(data.ToArray());
            
            List<byte> res = new List<byte>();
            res.Add(HEAD);
            byte size = Byte.Parse((data.Count() + 1).ToString());      //HEAD LENGTH | DATA... SUM
            res.Add(size);
            res.AddRange(data);
            res.Add(sum);

            return res.ToArray();
        }

        public void setData(bool isFly)
        {
            data.Add(type);
            if (isFly)
            {
                d = 1;
            }
            else
            {
                d = 0;
            }
            data.Add(d);
        }

        public override byte[] dealData(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
