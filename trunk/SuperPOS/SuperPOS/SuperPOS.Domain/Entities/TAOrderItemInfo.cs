using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAOrderItemInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "ItemQty")]
        public virtual string ItemQty { get; set; }

        //ItemDishName
        [XmlElement(ElementName = "ItemDishName")]
        public virtual string ItemDishName { get; set; }

        [XmlElement(ElementName = "ItemTotalPrice")]
        public virtual string ItemTotalPrice { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public virtual string ItemCode { get; set; }

        [XmlElement(ElementName = "ItemPrice")]
        public virtual string ItemPrice { get; set; }

        [XmlElement(ElementName = "CheckKey")]
        public virtual string CheckKey { get; set; }

        [XmlElement(ElementName = "CheckCode")]
        public virtual string CheckCode { get; set; }

        [XmlElement(ElementName = "OrderTime")]
        public virtual string OrderTime { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
