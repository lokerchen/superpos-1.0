using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class SysConfigInfo
    {
        //SystemKey
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //ShopName
        [XmlElement(ElementName = "ShopName")]
        public virtual string ShopName { get; set; }

        //ShopAddr
        [XmlElement(ElementName = "ShopAddr")]
        public virtual string ShopAddr { get; set; }

        //IsDisplayItemCodeSelect
        [XmlElement(ElementName = "IsDisplayItemCodeSelect")]
        public virtual string IsDisplayItemCodeSelect { get; set; }

        //IsInputNumberOfPerson
        [XmlElement(ElementName = "IsInputNumberOfPerson")]
        public virtual string IsInputNumberOfPerson { get; set; }

        //IsBackUpWhenExit
        [XmlElement(ElementName = "IsBackUpWhenExit")]
        public virtual string IsBackUpWhenExit { get; set; }

        //BackUpDrive
        [XmlElement(ElementName = "BackUpDrive")]
        public virtual string BackUpDrive { get; set; }

        //TillNum
        [XmlElement(ElementName = "TillNum")]
        public virtual string TillNum { get; set; }

        //DefaultOrderInputPage
        [XmlElement(ElementName = "DefaultOrderInputPage")]
        public virtual string DefaultOrderInputPage { get; set; }

        //Currency
        [XmlElement(ElementName = "Currency")]
        public virtual string Currency { get; set; }

        //VATPerct
        [XmlElement(ElementName = "VATPerct")]
        public virtual string VATPerct { get; set; }

        //IsUseCashDrawer
        [XmlElement(ElementName = "IsUseCashDrawer")]
        public virtual string IsUseCashDrawer { get; set; }

        //RptPrinter
        [XmlElement(ElementName = "RptPrinter")]
        public virtual string RptPrinter { get; set; }

        //A4RptPrinter
        [XmlElement(ElementName = "A4RptPrinter")]
        public virtual string A4RptPrinter { get; set; }

        //RoundUpDecimal
        [XmlElement(ElementName = "RoundUpDecimal")]
        public virtual string RoundUpDecimal { get; set; }

        //KeypadSet
        [XmlElement(ElementName = "KeypadSet")]
        public virtual string KeypadSet { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
