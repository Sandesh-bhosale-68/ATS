using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssNewJoinee
    {
        public int Id { get; set; }
        public string? EmpName { get; set; }
        public DateTime? Doj { get; set; }
        public string? Gender { get; set; }
        public string? Designation { get; set; }
        public string? Experience { get; set; }
        public string? Companies { get; set; }
        public string? SittingAt { get; set; }
        public int? LocationId { get; set; }
        public string? EmailId { get; set; }
        public string? Pics { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
