using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAMenuCategoryInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "EnglishName")]
        public virtual string EnglishName { get; set; }

        //Computer Name
        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "DisplayPosition")]
        public virtual string DisplayPosition { get; set; }

        //Remark
        [XmlElement(ElementName = "DeptSysKey")]
        public virtual string DeptSysKey { get; set; }

        //Remark
        [XmlElement(ElementName = "DeptCode")]
        public virtual string DeptCode { get; set; }

        //Remark
        [XmlElement(ElementName = "IsHotKey")]
        public virtual string IsHotKey { get; set; }

        //Remark
        [XmlElement(ElementName = "DishCode")]
        public virtual string DishCode { get; set; }
    }
}
