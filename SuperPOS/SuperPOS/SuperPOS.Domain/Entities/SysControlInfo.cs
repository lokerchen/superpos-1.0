using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class SysControlInfo
    {
        //SystemKey
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //IsTakeaway
        [XmlElement(ElementName = "IsTakeaway")]
        public virtual string IsTakeaway { get; set; }

        //IsEatIn
        [XmlElement(ElementName = "IsEatIn")]
        public virtual string IsEatIn { get; set; }

        //IsQuickFood
        [XmlElement(ElementName = "IsQuickFood")]
        public virtual string IsQuickFood { get; set; }

        //ShopName
        [XmlElement(ElementName = "ShopName")]
        public virtual string ShopName { get; set; }

        //Address
        [XmlElement(ElementName = "Address")]
        public virtual string Address { get; set; }

        //IsShopDetailReadOnly
        [XmlElement(ElementName = "IsShopDetailReadOnly")]
        public virtual string IsShopDetailReadOnly { get; set; }

        //IsNotAccountFor
        [XmlElement(ElementName = "IsNotAccountFor")]
        public virtual string IsNotAccountFor { get; set; }

        //Key1
        [XmlElement(ElementName = "Key1")]
        public virtual string Key1 { get; set; }

        //Key2
        [XmlElement(ElementName = "Key2")]
        public virtual string Key2 { get; set; }

        //AccessCode
        [XmlElement(ElementName = "AccessCode")]
        public virtual string AccessCode { get; set; }

        //ImgPath1
        [XmlElement(ElementName = "ImgPath1")]
        public virtual string ImgPath1 { get; set; }

        //ImgPath2
        [XmlElement(ElementName = "ImgPath2")]
        public virtual string ImgPath2 { get; set; }

        //ImgPath3
        [XmlElement(ElementName = "ImgPath3")]
        public virtual string ImgPath3 { get; set; }

        //ImgPath4
        [XmlElement(ElementName = "ImgPath4")]
        public virtual string ImgPath4 { get; set; }

        //ImgPath5
        [XmlElement(ElementName = "ImgPath5")]
        public virtual string ImgPath5 { get; set; }
    }
}
