using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class IpBlr
    {
        public int Id { get; set; }
        public int? LocationId { get; set; }
        public string? Ip { get; set; }
        public string? HostName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
