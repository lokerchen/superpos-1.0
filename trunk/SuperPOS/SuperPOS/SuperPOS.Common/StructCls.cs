using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SuperPOS.Common
{
    public class StructClass
    {
        public struct ParamInfo
        {
            public string Name;
            public object Value;
            public DbType Type;
            public int Size;
            public ParameterDirection Direction;
        }
        public struct ReturnMsgInfo
        {
            public string Name;
            public string ReturnMsg;
        }
    }
}
