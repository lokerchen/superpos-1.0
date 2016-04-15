using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAMenuItemSubMenuDetailInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "SubMenuID")]
        public virtual string SubMenuID { get; set; }

        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }
    }
}
