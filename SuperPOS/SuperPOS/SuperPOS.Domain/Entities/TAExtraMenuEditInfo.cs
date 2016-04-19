using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAExtraMenuEditInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "TasteOrDrink")]
        public virtual string TasteOrDrink { get; set; }

        [XmlElement(ElementName = "BtnName")]
        public virtual string BtnName { get; set; }

        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "Price")]
        public virtual string Price { get; set; }

        [XmlElement(ElementName = "DisplayPosition")]
        public virtual string DisplayPosition { get; set; }
    }
}
