using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TADistChargeRemarkInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "PerMileThereafter")]
        public virtual string PerMileThereafter { get; set; }

        //Computer Name
        [XmlElement(ElementName = "OrderThreshold")]
        public virtual string OrderThreshold { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "SurchargeAmount")]
        public virtual string SurchargeAmount { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "DeliveryChargeIncludesInOrder")]
        public virtual string DeliveryChargeIncludesInOrder { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "IgnoreDeliverySurchargeWhenDistExceeds")]
        public virtual string IgnoreDeliverySurchargeWhenDistExceeds { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "IgnoreDeliveryDistChargeIfSurchargeAppl")]
        public virtual string IgnoreDeliveryDistChargeIfSurchargeAppl { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
