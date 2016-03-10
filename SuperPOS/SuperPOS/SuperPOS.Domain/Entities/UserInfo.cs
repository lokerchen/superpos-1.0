using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class UserInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //用户密码
        [XmlElement(ElementName = "UsrCode")]
        public virtual string UsrCode { get; set; }

        //用户密码
        [XmlElement(ElementName = "UsrName")]
        public virtual string UsrName { get; set; }

        //用户名
        [XmlElement(ElementName = "UsrPwd")]
        public virtual string UsrPwd { get; set; }

        //是否System Control权限
        [XmlElement(ElementName = "IsSysCtrl")]
        public virtual string IsSysCtrl { get; set; }

        //用户权限
        [XmlElement(ElementName = "Remark")]
        public virtual int Remark { get; set; }
    }
}
