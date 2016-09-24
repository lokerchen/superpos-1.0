using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPostcodeZoneInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Postcode
        [XmlElement(ElementName = "Postcode")]
        public virtual string Postcode { get; set; }

        //Zone
        [XmlElement(ElementName = "Zone")]
        public virtual string Zone { get; set; }
    }
}
