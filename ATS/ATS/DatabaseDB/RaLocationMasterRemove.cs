using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RaLocationMasterRemove
    {
        public RaLocationMasterRemove()
        {
            RaReportmasterRemoves = new HashSet<RaReportmasterRemove>();
            RaSqlserverIpaddRemoves = new HashSet<RaSqlserverIpaddRemove>();
        }

        public long LocationId { get; set; }
        public string? LocationName { get; set; }
        public DateTime? CrDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<RaReportmasterRemove> RaReportmasterRemoves { get; set; }
        public virtual ICollection<RaSqlserverIpaddRemove> RaSqlserverIpaddRemoves { get; set; }
    }
}
