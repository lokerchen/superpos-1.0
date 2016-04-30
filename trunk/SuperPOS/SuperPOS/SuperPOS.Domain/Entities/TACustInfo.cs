using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TACustInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "Phone1")]
        public virtual string Phone1 { get; set; }

        [XmlElement(ElementName = "Name")]
        public virtual string Name { get; set; }

        [XmlElement(ElementName = "HouseNo")]
        public virtual string HouseNo { get; set; }

        [XmlElement(ElementName = "Address1")]
        public virtual string Address1 { get; set; }

        [XmlElement(ElementName = "Postcode1")]
        public virtual string Postcode1 { get; set; }

        [XmlElement(ElementName = "Distance")]
        public virtual string Distance { get; set; }

        [XmlElement(ElementName = "PcZone")]
        public virtual string PcZone { get; set; }

        [XmlElement(ElementName = "DelCharge")]
        public virtual string DelCharge { get; set; }

        [XmlElement(ElementName = "ReadyTime")]
        public virtual string ReadyTime { get; set; }

        [XmlElement(ElementName = "IntNotes")]
        public virtual string IntNotes { get; set; }

        [XmlElement(ElementName = "NotesOnBill")]
        public virtual string NotesOnBill { get; set; }

        [XmlElement(ElementName = "IsBlackListed")]
        public virtual string IsBlackListed { get; set; }

        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
