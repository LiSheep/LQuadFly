using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQuadFly.Common;

namespace LQuadFly.Message
{
    public class PIDWriteMessage : BaseMessage
    {
        int wri = 0;
        List<byte> data = new List<byte>();

        public PIDWriteMessage()
            : base(Dictionary.PROTOCOL_ROM_W)
        { }

        public void setData(string rp, string ri, string rd, string pp, string pi, string pd)
        {
            data.Add(type);
            data.AddRange(BitConverter.GetBytes(float.Parse(rp)));
            data.AddRange(BitConverter.GetBytes(float.Parse(ri)));
            data.AddRange(BitConverter.GetBytes(float.Parse(rd)));

            data.AddRange(BitConverter.GetBytes(float.Parse(pp)));
            data.AddRange(BitConverter.GetBytes(float.Parse(pi)));
            data.AddRange(BitConverter.GetBytes(float.Parse(pd)));

        }

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

        public override byte[] dealData(byte[] data)
        {
            byte[] ret = new byte[1];
            ret[0] = data[1];
            return ret;
        }
    }
}
