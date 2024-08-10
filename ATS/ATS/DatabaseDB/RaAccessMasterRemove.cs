using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RaAccessMasterRemove
    {
        public long AccessId { get; set; }
        public string? EmpCode { get; set; }
        public long? ReportId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CrDate { get; set; }

        public virtual RaReportmasterRemove? Report { get; set; }
    }
}
