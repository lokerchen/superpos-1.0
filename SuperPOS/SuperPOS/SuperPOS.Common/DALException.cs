using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SuperPOS.Common
{
    public class DALException : Exception
    {
        public DALException()
        {
        }

        public DALException(string sMessage) : base(sMessage)
        {
        }

        public DALException(string sMessage, Exception exception) : base(sMessage, exception)
        {
        }

        public DALException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        //public override string Message
        //{
        //    get { return base.Message; }
        //}
        public override string Message => base.Message;
    }
}
