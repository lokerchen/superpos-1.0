using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TADeptCodeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //Code
        [XmlElement(ElementName = "DeptCode")]
        public virtual string DeptCode { get; set; }

        //Computer Name
        [XmlElement(ElementName = "DeptName")]
        public virtual string DeptName { get; set; }

        //Add/Edit DateTime
        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }
    }
}
