using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RollMaster
    {
        public int RollMasterId { get; set; }
        public string? Roll { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Deleted { get; set; }
    }
}
