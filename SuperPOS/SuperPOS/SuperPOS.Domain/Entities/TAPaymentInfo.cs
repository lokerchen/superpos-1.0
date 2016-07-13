using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPaymentInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "ChkNum")]
        public virtual string ChkNum { get; set; }

        [XmlElement(ElementName = "PayType1")]
        public virtual string PayType1 { get; set; }

        [XmlElement(ElementName = "PayTypeSurCharge1")]
        public virtual string PayTypeSurCharge1 { get; set; }

        [XmlElement(ElementName = "PayType2")]
        public virtual string PayType2 { get; set; }

        [XmlElement(ElementName = "PayTypeSurCharge2")]
        public virtual string PayTypeSurCharge2 { get; set; }

        [XmlElement(ElementName = "PayType3")]
        public virtual string PayType3 { get; set; }

        [XmlElement(ElementName = "PayTypeSurCharge3")]
        public virtual string PayTypeSurCharge3 { get; set; }

        [XmlElement(ElementName = "PayType4")]
        public virtual string PayType4 { get; set; }

        [XmlElement(ElementName = "PayTypeSurCharge4")]
        public virtual string PayTypeSurCharge4 { get; set; }

        [XmlElement(ElementName = "NotPaid")]
        public virtual string NotPaid { get; set; }

        [XmlElement(ElementName = "Delivery")]
        public virtual string Delivery { get; set; }

        [XmlElement(ElementName = "Discount")]
        public virtual string Discount { get; set; }

        [XmlElement(ElementName = "DiscountValue")]
        public virtual string DiscountValue { get; set; }

        [XmlElement(ElementName = "Surcharge")]
        public virtual string Surcharge { get; set; }

        [XmlElement(ElementName = "Tendered")]
        public virtual string Tendered { get; set; }

        [XmlElement(ElementName = "ToPay")]
        public virtual string ToPay { get; set; }

        [XmlElement(ElementName = "ForChange")]
        public virtual string ForChange { get; set; }

        [XmlElement(ElementName = "DCNote")]
        public virtual string DCNote { get; set; }

        [XmlElement(ElementName = "CustInfo")]
        public virtual string CustInfo { get; set; }

        [XmlElement(ElementName = "IsPaid")]
        public virtual string IsPaid { get; set; }

        [XmlElement(ElementName = "AcctPay")]
        public virtual string AcctPay { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public virtual string DriverName { get; set; }

        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
