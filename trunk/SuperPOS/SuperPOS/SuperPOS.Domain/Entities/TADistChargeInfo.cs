using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TADistChargeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "DistFrom")]
        public virtual string DistFrom { get; set; }

        //Computer Name
        [XmlElement(ElementName = "DistTo")]
        public virtual string DistTo { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "DistAmout")]
        public virtual string DistAmout { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
