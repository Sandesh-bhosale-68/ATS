using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvFilterMaster
    {
        public long FId { get; set; }
        public string? FText { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
