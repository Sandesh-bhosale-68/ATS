using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class StarCjReasonRemove
    {
        public decimal Id { get; set; }
        public string Reason { get; set; } = null!;
        public string SubReason { get; set; } = null!;
    }
}
