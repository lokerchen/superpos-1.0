using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPayTypeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "PaymentType")]
        public virtual string PaymentType { get; set; }

        //Computer Name
        [XmlElement(ElementName = "SurchargeThreshold")]
        public virtual string SurchargeThreshold { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "SurchargeAmount")]
        public virtual string SurchargeAmount { get; set; }

        [XmlElement(ElementName = "SurchargePercent")]
        public virtual string SurchargePercent { get ; set ; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
