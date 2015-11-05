using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPostCodeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "PostCode")]
        public virtual string PostCode { get; set; }

        //Computer Name
        [XmlElement(ElementName = "Address")]
        public virtual string Address { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "Map")]
        public virtual string Map { get; set; }

        [XmlElement(ElementName = "Distance")]
        public virtual string Distance { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
