using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SubProcessTbl
    {
        public int Id { get; set; }
        public string? SubProcess { get; set; }
        public int? ProcId { get; set; }
        public int? LocationId { get; set; }

        public virtual ProcessTbl? Proc { get; set; }
    }
}
