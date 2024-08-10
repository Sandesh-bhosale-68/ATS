using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblReasonForSeperation
    {
        public string? Type { get; set; }
        public string? Reason { get; set; }
        public int? IsActive { get; set; }
    }
}
