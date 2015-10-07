using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class UserMaintenanceInfo
    {
        //SystemKey
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //UsrCode
        [XmlElement(ElementName = "UsrCode")]
        public virtual string UsrCode { get; set; }

        //Take Away Access - Control Panel
        [XmlElement(ElementName = "TACtlPanel")]
        public virtual string TACtlPanel { get; set; }

        //Take Away Access - Change Price
        [XmlElement(ElementName = "TAChangePrice")]
        public virtual string TAChangePrice { get; set; }

        //Take Away Access - Show Order / Print Acct Summary
        [XmlElement(ElementName = "TASOPrtAcctSum")]
        public virtual string TASOPrtAcctSum { get; set; }

        //Take Away Access - Show Order / Change Payment
        [XmlElement(ElementName = "TASOChangePayment")]
        public virtual string TASOChangePayment { get; set; }

        //Take Away Access - Show Order / Endit Order
        [XmlElement(ElementName = "TASOEditOrder")]
        public virtual string TASOEditOrder { get; set; }

        //Take Away Access - Show Order / Print Receipt
        [XmlElement(ElementName = "TASOPrtReceipt")]
        public virtual string TASOPrtReceipt { get; set; }

        ////Take Away Access - Customer List / Export Data
        [XmlElement(ElementName = "TACLExportData")]
        public virtual string TACLExportData { get; set; }

        //Quick Dining Access - Control Panel
        [XmlElement(ElementName = "QDCtlPanel")]
        public virtual string QDCtlPanel { get; set; }

        //Quick Dining Access - Change Price
        [XmlElement(ElementName = "QDChangePrice")]
        public virtual string QDChangePrice { get; set; }

        //Quick Dining Access - Show Order / Print Acct Summary
        [XmlElement(ElementName = "QDSOPrtAcctSum")]
        public virtual string QDSOPrtAcctSum { get; set; }

        //Quick Dining Access - Show Order / Change Payment
        [XmlElement(ElementName = "QDSOChangePayment")]
        public virtual string QDSOChangePayment { get; set; }

        //Quick Dining Access - Show Order / Edit Order 
        [XmlElement(ElementName = "QDSOEditOrder")]
        public virtual string QDSOEditOrder { get; set; }

        //Quick Dining Access - Show Order / Print Receipt
        [XmlElement(ElementName = "QDSOPrtReceipt")]
        public virtual string QDSOPrtReceipt { get; set; }

        //General Access - System Setting / System Config
        [XmlElement(ElementName = "GSSSystemConfig")]
        public virtual string GSSSystemConfig { get; set; }

        //General Access - System Setting / User Maintenance
        [XmlElement(ElementName = "GSSUsrMaint")]
        public virtual string GSSUsrMaint { get; set; }

        //General Access - System Setting / Data Manager
        [XmlElement(ElementName = "GSSDataManager")]
        public virtual string GSSDataManager { get; set; }

        //General Access - System Setting / Compact Database
        [XmlElement(ElementName = "GSSCompactDb")]
        public virtual string GSSCompactDb { get; set; }

        //General Access - Reproting / Reports
        [XmlElement(ElementName = "GRpt")]
        public virtual string GRpt { get; set; }

        //General Access - Reporting / Account Summary
        [XmlElement(ElementName = "GRAccountSum")]
        public virtual string GRAccountSum { get; set; }

        //General Access - Account Summary / Summary View
        [XmlElement(ElementName = "GASSumView")]
        public virtual string GASSumView { get; set; }

        //General Access - Logon screen EXIT POS Software
        [XmlElement(ElementName = "GExitPos")]
        public virtual string GExitPos { get; set; }

        //General Access - System Setting / Computer Add.
        [XmlElement(ElementName = "GSSCoputAdd")]
        public virtual string GSSCoputAdd { get; set; }

        //General Access - System Setting / Shift Code
        [XmlElement(ElementName = "GSSShiftCode")]
        public virtual string GSSShiftCode { get; set; }

        //General Access - Takeaway Configuration
        [XmlElement(ElementName = "GTakeawayConfig")]
        public virtual string GTakeawayConfig { get; set; }

        //General Access - Eat-In Configuration
        [XmlElement(ElementName = "GEatInConfig")]
        public virtual string GEatInConfig { get; set; }

        //General Access - Takeaway / Print Setup
        [XmlElement(ElementName = "GTakewayPrtSetUp")]
        public virtual string GTakewayPrtSetUp { get; set; }

        //General Access - Eat-In / Print Setup
        [XmlElement(ElementName = "GEatInPrtSetUp")]
        public virtual string GEatInPrtSetUp { get; set; }

        //General Access - Account Summary / Print Sales Rpt
        [XmlElement(ElementName = "GASPrtSalesRpt")]
        public virtual string GASPrtSalesRpt { get; set; }

        //General Access - Open Cash Drawer
        [XmlElement(ElementName = "GOpenCash")]
        public virtual string GOpenCash { get; set; }

        //Eat-In Access - Control Panel
        [XmlElement(ElementName = "EICtlPanel")]
        public virtual string EICtlPanel { get; set; }

        //Eat-In Access - Pay
        [XmlElement(ElementName = "EIPay")]
        public virtual string EIPay { get; set; }

        //Eat-In Access - Print Bill
        [XmlElement(ElementName = "EIPrtBill")]
        public virtual string EIPrtBill { get; set; }

        //Eat-In Access - Remove Item After Printed
        [XmlElement(ElementName = "EIRemoveItemAfterPrt")]
        public virtual string EIRemoveItemAfterPrt { get; set; }

        //Eat-In Access - Table Booking
        [XmlElement(ElementName = "EITblBooking")]
        public virtual string EITblBooking { get; set; }

        //Eat-In Access - Show Order / Print Acct Summary
        [XmlElement(ElementName = "EISOPrtAcctSum")]
        public virtual string EISOPrtAcctSum { get; set; }

        //Eat-In Access - Show Order / Change Payment
        [XmlElement(ElementName = "EISOChangePayment")]
        public virtual string EISOChangePayment { get; set; }

        //Eat-In Access - Show Order / Edit Order 
        [XmlElement(ElementName = "EISOEditOrder")]
        public virtual string EISOEditOrder { get; set; }

        //Eat-In Access - Show Order / Print Receipt
        [XmlElement(ElementName = "EISOPrtReceipt")]
        public virtual string EISOPrtReceipt { get; set; }

        //Eat-In Access - Print Bill / Discount
        [XmlElement(ElementName = "EIPBDicount")]
        public virtual string EIPBDicount { get; set; }

        //Remark
        [XmlElement(ElementName = "Remark")]
        public virtual string Remark { get; set; }
    }
}
