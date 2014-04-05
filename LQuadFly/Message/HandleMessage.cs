using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQuadFly.Message
{
    public static class HandleMessage
    {
        public static byte[] getDataToWrite(BaseMessage msg)
        {
            return msg.getOutData();
        }

       
    }
}
