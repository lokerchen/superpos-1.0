using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAMenuItemTCInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "MenuItemID")]
        public virtual string MenuItemID { get; set; }

        [XmlElement(ElementName = "MenuSetID")]
        public virtual string MenuSetID { get; set; }

        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "AddPrice")]
        public virtual string AddPrice { get; set; }

        [XmlElement(ElementName = "AutoAppend")]
        public virtual string AutoAppend { get; set; }

        [XmlElement(ElementName = "IsEnableChoices")]
        public virtual string IsEnableChoices { get; set; }
    }
}
