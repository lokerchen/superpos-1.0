using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TADriverSetUpInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public virtual string DriverName { get; set; }

        [XmlElement(ElementName = "DriverPhone")]
        public virtual string DriverPhone { get; set; }

        [XmlElement(ElementName = "DriverWorkDay")]
        public virtual string DriverWorkDay { get; set; }

        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
