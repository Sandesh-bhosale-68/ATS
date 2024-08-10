using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class StarCjsystemLoginRemove
    {
        public decimal Id { get; set; }
        public string? EmpCode { get; set; }
        public string? SystemName { get; set; }
        public string? SystemIp { get; set; }
        public string? WindowLogin { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
    }
}
