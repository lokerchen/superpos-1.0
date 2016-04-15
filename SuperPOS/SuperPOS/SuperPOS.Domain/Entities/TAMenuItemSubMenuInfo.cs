using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAMenuItemSubMenuInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "DishCode")]
        public virtual string DishCode { get; set; }

        [XmlElement(ElementName = "DisplayPosition")]
        public virtual string DisplayPosition { get; set; }

        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "Price")]
        public virtual string Price { get; set; }

        [XmlElement(ElementName = "IsUnavailable")]
        public virtual string IsUnavailable { get; set; }

        [XmlElement(ElementName = "IsDiscountable")]
        public virtual string IsDiscountable { get; set; }

        [XmlElement(ElementName = "IsInventoryChk")]
        public virtual string IsInventoryChk { get; set; }

        [XmlElement(ElementName = "IsNegativePrice")]
        public virtual string IsNegativePrice { get; set; }

        [XmlElement(ElementName = "IsWithoutVAT")]
        public virtual string IsWithoutVAT { get; set; }

        [XmlElement(ElementName = "SplyShift")]
        public virtual string SplyShift { get; set; }

        [XmlElement(ElementName = "IsPrtName")]
        public virtual string IsPrtName { get; set; }

        [XmlElement(ElementName = "IsPrtOrder")]
        public virtual string IsPrtOrder { get; set; }
    }
}
