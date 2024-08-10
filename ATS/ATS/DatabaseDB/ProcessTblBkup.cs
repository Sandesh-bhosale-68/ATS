using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProcessTblBkup
    {
        public int Pid { get; set; }
        public string? Process { get; set; }
        public string? Location { get; set; }
        public int? DeptId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
