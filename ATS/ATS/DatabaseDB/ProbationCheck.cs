using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProbationCheck
    {
        public decimal Id { get; set; }
        public string? Empcode { get; set; }
        public int? ProbationDays { get; set; }
        public int? ExtensionDays { get; set; }
        public string? Reason { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? Empname { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ExtensionCount { get; set; }
    }
}
