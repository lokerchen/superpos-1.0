using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TADeptCodeDetailInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "DeptCodeSysKey")]
        public virtual string DeptCodeSysKey { get; set; }

        //Computer Name
        [XmlElement(ElementName = "PrintName1")]
        public virtual string PrintName1 { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "NumCopy1")]
        public virtual string NumCopy1 { get; set; }

        //Remark
        [XmlElement(ElementName = "PrtDishSeper1")]
        public virtual string PrtDishSeper1 { get; set; }

        [XmlElement(ElementName = "PrintName2")]
        public virtual string PrintName2 { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "NumCopy2")]
        public virtual string NumCopy2 { get; set; }

        //Remark
        [XmlElement(ElementName = "PrtDishSeper2")]
        public virtual string PrtDishSeper2 { get; set; }
    }
}
