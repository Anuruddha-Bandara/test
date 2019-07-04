using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nic { get; set; }
        public string Address { get; set; }
        public string MobileNo1 { get; set; }
        public string MobileNo2 { get; set; }
        public bool? SetSmsforNo1 { get; set; }
        public string LandNo { get; set; }
        public bool? SendSms { get; set; }
        public int? ReminderDuration { get; set; }
    }
}
