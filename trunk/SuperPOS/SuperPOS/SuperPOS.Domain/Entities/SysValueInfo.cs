using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class SysValueInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "PropMod")]
        public virtual string PropMod { get; set; }

        [XmlElement(ElementName = "PropName")]
        public virtual string PropName { get; set; }

        [XmlElement(ElementName = "PropValue")]
        public virtual string PropValue { get; set; }

        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
