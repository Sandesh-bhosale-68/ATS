using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RaReportmasterRemove
    {
        public RaReportmasterRemove()
        {
            RaAccessMasterRemoves = new HashSet<RaAccessMasterRemove>();
        }

        public long ReportId { get; set; }
        public string? ReportName { get; set; }
        public long? LocationId { get; set; }
        public string? SpName { get; set; }
        public string? IsParam { get; set; }
        public long? SqlserverId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CrDate { get; set; }
        public string? Dbname { get; set; }

        public virtual RaLocationMasterRemove? Location { get; set; }
        public virtual RaSqlserverIpaddRemove? Sqlserver { get; set; }
        public virtual ICollection<RaAccessMasterRemove> RaAccessMasterRemoves { get; set; }
    }
}
