using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPostCodeRemarkInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "UrSTD")]
        public virtual string UrSTD { get; set; }

        //Computer Name
        [XmlElement(ElementName = "UrPostCode")]
        public virtual string UrPostCode { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "UrX")]
        public virtual string UrX { get; set; }

        [XmlElement(ElementName = "UrY")]
        public virtual string UrY { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
