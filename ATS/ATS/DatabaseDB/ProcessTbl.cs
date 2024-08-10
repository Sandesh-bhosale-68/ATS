using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProcessTbl
    {
        public ProcessTbl()
        {
            SubProcessTbls = new HashSet<SubProcessTbl>();
        }

        public int Pid { get; set; }
        public string? Process { get; set; }
        public int? LocationId { get; set; }
        public int? DeptId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<SubProcessTbl> SubProcessTbls { get; set; }
    }
}
