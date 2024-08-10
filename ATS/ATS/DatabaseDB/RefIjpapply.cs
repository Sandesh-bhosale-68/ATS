using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefIjpapply
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string? PostAppliedFor { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeCode { get; set; }
        public string? Doj { get; set; }
        public string? Designation { get; set; }
        public string? Process { get; set; }
        public string? ReportingTo { get; set; }
        public string? TotalExperience { get; set; }
        public string ContactNo { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}
