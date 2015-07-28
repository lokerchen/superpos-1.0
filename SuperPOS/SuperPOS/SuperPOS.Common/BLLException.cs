using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SuperPOS.Common
{
    public class BLLException : Exception
    {
        public BLLException()
        {
        }

        public BLLException(string message) : base(message)
        {
        }

        public BLLException(string message, Exception exception) : base(message, exception)
        {
        }

        public BLLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        //public override string Message
        //{
        //    get { return base.Message; }
        //}
        public override string Message => base.Message;
    }
}
