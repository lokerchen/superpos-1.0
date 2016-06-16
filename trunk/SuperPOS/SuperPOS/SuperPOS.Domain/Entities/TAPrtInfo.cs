using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPrtInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "TelNo")]
        public virtual string TelNo { get; set; }

        [XmlElement(ElementName = "VATNo")]
        public virtual string VATNo { get; set; }

        [XmlElement(ElementName = "Message1")]
        public virtual string Message1 { get; set; }

        [XmlElement(ElementName = "Message2")]
        public virtual string Message2 { get; set; }

        [XmlElement(ElementName = "Message3")]
        public virtual string Message3 { get; set; }

        [XmlElement(ElementName = "Message4")]
        public virtual string Message4 { get; set; }

        [XmlElement(ElementName = "Message5")]
        public virtual string Message5 { get; set; }
    }
}
