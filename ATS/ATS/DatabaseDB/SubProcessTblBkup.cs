using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SubProcessTblBkup
    {
        public int Id { get; set; }
        public string? SubProcess { get; set; }
        public int? ProcId { get; set; }
    }
}
