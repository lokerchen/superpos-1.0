using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TATblSetupInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "BtnNum")]
        public virtual string BtnNum { get; set; }

        [XmlElement(ElementName = "RefNum")]
        public virtual string RefNum { get; set; }
    }
}
