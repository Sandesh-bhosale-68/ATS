using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DojHandoverUpdate
    {
        public string? EmpCode { get; set; }
        public string? FirstName { get; set; }
        public DateTime? PayrollDot { get; set; }
        public DateTime? PayrollDoj { get; set; }
        public DateTime? OpsHandoverDateAsPerTrainingNhtTracker { get; set; }
        public string? Location { get; set; }
        public string? Remarks { get; set; }
    }
}
