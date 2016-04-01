using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAMenuItemInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "DishCode")]
        public virtual string DishCode { get; set; }

        //Code
        [XmlElement(ElementName = "DisplayPosition")]
        public virtual string DisplayPosition { get; set; }

        //Computer Name
        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        //Remark
        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "wLarge")]
        public virtual string wLarge { get; set; }

        [XmlElement(ElementName = "wRegular")]
        public virtual string wRegular { get; set; }

        [XmlElement(ElementName = "wSmall")]
        public virtual string wSmall { get; set; }

        [XmlElement(ElementName = "SpecialLarge")]
        public virtual string SpecialLarge { get; set; }

        [XmlElement(ElementName = "SpecialRegular")]
        public virtual string SpecialRegular { get; set; }

        [XmlElement(ElementName = "SpecialSmall")]
        public virtual string SpecialSmall { get; set; }

        [XmlElement(ElementName = "BtnColor")]
        public virtual string BtnColor { get; set; }

        [XmlElement(ElementName = "SupplyShift")]
        public virtual string SupplyShift { get; set; }

        [XmlElement(ElementName = "PrinterName")]
        public virtual string PrinterName { get; set; }

        [XmlElement(ElementName = "PrinterOrder")]
        public virtual string PrinterOrder { get; set; }

        [XmlElement(ElementName = "Qty")]
        public virtual string Qty { get; set; }

        [XmlElement(ElementName = "IsUnavailable")]
        public virtual string IsUnavailable { get; set; }

        [XmlElement(ElementName = "IsNegativePrice")]
        public virtual string IsNegativePrice { get; set; }

        [XmlElement(ElementName = "IsDiscountable")]
        public virtual string IsDiscountable { get; set; }

        [XmlElement(ElementName = "IsNegativePrice")]
        public virtual string IsWithoutVAT { get; set; }

        [XmlElement(ElementName = "IsWithoutVAT")]
        public virtual string IsInventoryCheck { get; set; }

        [XmlElement(ElementName = "MenuSetID")]
        public virtual string MenuSetID { get; set; }

        [XmlElement(ElementName = "MenuCateID")]
        public virtual string MenuCateID { get; set; }
    }
}