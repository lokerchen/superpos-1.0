using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class SysControlInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "IsTakeaway")]
        public virtual string IsTakeaway { get; set; }

        //Computer Name
        [XmlElement(ElementName = "IsEatIn")]
        public virtual string IsEatIn { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "IsQuickFood")]
        public virtual string IsQuickFood { get; set; }

        //Remark
        [XmlElement(ElementName = "ShopName")]
        public virtual string ShopName { get; set; }

        [XmlElement(ElementName = "Address")]
        public virtual string Address { get; set; }

        [XmlElement(ElementName = "IsShopDetailReadOnly")]
        public virtual string IsShopDetailReadOnly { get; set; }

        [XmlElement(ElementName = "IsNotAccountFor")]
        public virtual string IsNotAccountFor { get; set; }

        [XmlElement(ElementName = "Key1")]
        public virtual string Key1 { get; set; }

        [XmlElement(ElementName = "Key2")]
        public virtual string Key2 { get; set; }

        [XmlElement(ElementName = "AccessCode")]
        public virtual string AccessCode { get; set; }
    }
}
