using System;

namespace Thinh_Ecom.Models
{
    public class HistoryPaymentModels
    {
        public string PaymentId { get; set; }
        public DateTime Date { get; set; }
        public bool Status_Confirm { get; set; }
        public string Name_Product { get; set; }
        public string Type_Payment { get; set; }
        public bool Check_Receive { get; set; }
        public int Price { get; set; }
    }
}
