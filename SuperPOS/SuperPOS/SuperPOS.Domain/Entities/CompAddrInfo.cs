using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class CompAddrInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "AddrCode")]
        public virtual string AddrCode { get; set; }

        //Computer Name
        [XmlElement(ElementName = "CompName")]
        public virtual string CompName { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual int Remark { get; set; }
    }
}
