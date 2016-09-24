using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPostcodeChargeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Postcode
        [XmlElement(ElementName = "Postcode")]
        public virtual string Postcode { get; set; }

        //Charge
        [XmlElement(ElementName = "Charge")]
        public virtual string Charge { get; set; }
    }
}
