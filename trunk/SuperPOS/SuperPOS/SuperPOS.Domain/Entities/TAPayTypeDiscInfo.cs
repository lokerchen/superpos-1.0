using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAPayTypeDiscInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "DeliveryDisc")]
        public virtual string DeliveryDisc { get; set; }

        //Computer Name
        [XmlElement(ElementName = "DeliveryDiscThres")]
        public virtual string DeliveryDiscThres { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "CollectionDisc")]
        public virtual string CollectionDisc { get; set; }

        [XmlElement(ElementName = "CollectionDiscThres")]
        public virtual string CollectionDiscThres { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "ShopDisc")]
        public virtual string ShopDisc { get; set; }

        [XmlElement(ElementName = "ShopDiscThres")]
        public virtual string ShopDiscThres { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
