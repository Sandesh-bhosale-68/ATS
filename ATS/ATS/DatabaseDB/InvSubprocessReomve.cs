using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InvSubprocessReomve
    {
        public int Id { get; set; }
        public string? SubProcess { get; set; }
        public int? ProcessId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
