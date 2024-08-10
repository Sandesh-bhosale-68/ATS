using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProcessMaster
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Process { get; set; }
        public string? SubProcess { get; set; }
        public bool? Status { get; set; }
    }
}
