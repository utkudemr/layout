using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class ERP_DATA:IEntity
    {
        public int Id { get; set; }
        public int? RowID { get; set; }
        public DateTime? ProjectDate { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? Completion_Date { get; set; }//
        public string Line { get; set; }//odt emty
        public string Industrial_Model { get; set; }
        public double? Power { get; set; }
        public int? Quantity { get; set; }
        public double? Slot { get; set; }//slot toplamı
        public string Slitting_Plan { get; set; }
        public string Tank_Type { get; set; }
        public string MIB_Plan { get; set; }
        public string MIB_Revise { get; set; }
        public DateTime? MIB_Real { get; set; }
        public double? MIB_Main_Item { get; set; }
        public DateTime? BOM_Plan { get; set; }
        public DateTime? BOM_Revise { get; set; }
        public DateTime? BOM_Real { get; set; }
        public string BOM_Main_Item { get; set; }
        public string Oil_Type { get; set; }
        public string OLTC { get; set; }
        public double? YG { get; set; }
        public double? AG { get; set; }
        public string CELL { get; set; }
        public double? Amount { get; set; }
        public string CurrencyOrder { get; set; }
        public double? Order_Amount { get; set; }
        public DateTime? Inv_Plan_Date { get; set; }
        public DateTime? Actual_Inv_Date { get; set; }
        public DateTime? Shipment_Date { get; set; }
        public DateTime? Planned_Receipt_Date { get; set; }
        public DateTime? Min_Req_Rec_Date { get; set; }
        public string Incoterm { get; set; }
        public string Project_Manager { get; set; }
        public string PM_Name { get; set; }
        public string Customer_Code { get; set; }
        public string Customer_Country { get; set; }
        public DateTime? Cont_Exw_Date { get; set; }
        public DateTime? Order_Date { get; set; }
        public string Budget { get; set; }
        public DateTime? Approval_Date { get; set; }
    }
}
