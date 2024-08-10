using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpComplaint
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? SalaryHeads { get; set; }
        public string? IssueDescription { get; set; }
        public string? Status { get; set; }
        public string? Hrfeedback { get; set; }
        public string? SalaryYear { get; set; }
        public string? SalaryMonth { get; set; }
        public int? TicketNo { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
