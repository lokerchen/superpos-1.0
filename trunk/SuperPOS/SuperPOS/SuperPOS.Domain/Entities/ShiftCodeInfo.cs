using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class ShiftCodeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "ShiftCode")]
        public virtual int ShiftCode { get; set; }

        [XmlElement(ElementName = "ShiftName")]
        public virtual string ShiftName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "DtFrom")]
        public virtual string DtFrom { get; set; }

        [XmlElement(ElementName = "DtTo")]
        public virtual string DtTo { get; set; }

        [XmlElement(ElementName = "SpecialEnable")]
        public virtual int SpecialEnable { get; set; }

        [XmlElement(ElementName = "SpecialContent")]
        public virtual string SpecialContent { get; set; }

        //[XmlElement(ElementName = "SpecialPrice")]
        //public virtual string SpecialPrice { get; set; }
    }
}
