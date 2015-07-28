using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperPOS.Domain.Entities;

namespace SuperPOS.IDAL
{
    interface IUsrList
    {
        IList<UserInfo> UsrList;
    }
}
