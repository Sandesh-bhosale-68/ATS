using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RaSqlserverIpaddRemove
    {
        public RaSqlserverIpaddRemove()
        {
            RaReportmasterRemoves = new HashSet<RaReportmasterRemove>();
        }

        public long SqlServerId { get; set; }
        public string? ServerDesc { get; set; }
        public long? ServerLoc { get; set; }
        public DateTime? CrDate { get; set; }
        public bool? IsActive { get; set; }
        public string? ServerUserId { get; set; }
        public string? ServerPassWd { get; set; }

        public virtual RaLocationMasterRemove? ServerLocNavigation { get; set; }
        public virtual ICollection<RaReportmasterRemove> RaReportmasterRemoves { get; set; }
    }
}
