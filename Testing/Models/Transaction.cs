using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PayType { get; set; }
        public double Cash { get; set; }
        public double Credit { get; set; }
        public double TotalAmount { get; set; }
        public string BillNumber { get; set; }
        public string CustomerName { get; set; }
        public double? TempBalance { get; set; }
        public string Status { get; set; }
    }
}
