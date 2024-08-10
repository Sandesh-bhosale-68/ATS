using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProcessMaster1
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; } = null!;
        public int? LocationId { get; set; }
        public string? SubprocessName { get; set; }
    }
}
