using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblOutcome
    {
        public decimal Id { get; set; }
        public string? Masterid { get; set; }
        public string? Empname { get; set; }
        public string? Refby { get; set; }
        public string? Interviewby { get; set; }
        public string? Remark { get; set; }
        public string? Outcome { get; set; }
        public string? Secinterby { get; set; }
        public string? Secinterempcode { get; set; }
        public int? AcademicRecord { get; set; }
        public int? PastExp { get; set; }
        public int? JobKnow { get; set; }
        public int? CommSkill { get; set; }
        public int? StabFac { get; set; }
        public int? InterPerf { get; set; }
        public int? ConfLevel { get; set; }
        public int? AppPers { get; set; }
        public int? Total { get; set; }
        public DateTime? InterDate { get; set; }
        public string? Comments { get; set; }
        public string? Status { get; set; }
        public DateTime? Doj { get; set; }
        public string? NextIntrv { get; set; }
        public string? Process { get; set; }
        public DateTime? InsertedDate { get; set; }
        public string? OpsName { get; set; }
        public string? OpsDesig { get; set; }
    }
}
