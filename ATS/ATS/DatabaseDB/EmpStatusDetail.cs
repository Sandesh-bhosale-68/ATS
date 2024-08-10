using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpStatusDetail
    {
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string LmempCode { get; set; } = null!;
        public string? Status { get; set; }
        public string? Reason { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
