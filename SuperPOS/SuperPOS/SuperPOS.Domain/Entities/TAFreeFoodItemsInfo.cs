using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAFreeFoodItemsInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "FreeAmount")]
        public virtual string FreeAmount { get; set; }

        [XmlElement(ElementName = "FreeCode")]
        public virtual string FreeCode { get; set; }

        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
