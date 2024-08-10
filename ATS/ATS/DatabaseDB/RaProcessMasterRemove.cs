using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RaProcessMasterRemove
    {
        public long ProcessId { get; set; }
        public string? ProcessName { get; set; }
        public string? UserId { get; set; }
        public DateTime? CrDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public int? IsActive { get; set; }
    }
}
