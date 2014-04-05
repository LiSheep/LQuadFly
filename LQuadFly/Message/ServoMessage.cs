using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQuadFly.Common;

namespace LQuadFly.Message
{
    public class ServoMessage : BaseMessage
    {
        public static int SERVO_PRE_LEFT = 0;
        public static int SERVO_PRE_RIGHT = 1;
        public static int SERVO_BACK_LEFT = 2;
        public static int SERVO_BACK_RIGHT = 3;

        private List<byte> m_data = new List<byte>();

        public ServoMessage()
            : base(Dictionary.PROTOCOL_SERVO)
        {
        }

        public void setData(decimal[] servos )
        {
            m_data.Add(type);
            foreach (decimal servo in servos)
            {
                m_data.Add(Byte.Parse(servo.ToString()));
            }
            
        }

        public override byte[] getOutData()
        {
            byte sum = getSum(m_data.ToArray());

            List<byte> buff = new List<byte>();
            buff.Add(HEAD);
            byte size = Byte.Parse((m_data.Count() + 1).ToString());      //HEAD LENGTH | DATA... SUM
            buff.Add(size);
            buff.AddRange(m_data); //(type + data)
            buff.Add(sum);
            return buff.ToArray();
        }

        public override byte[] dealData(byte[] data)
        {
            List<byte> result = new List<byte>();
            result.Add(data[1]);
            return result.ToArray();
        }
    }
}
