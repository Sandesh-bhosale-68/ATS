using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InternalComplaintsCommitteeMaster
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public int? LocationId { get; set; }
        public string? Name { get; set; }
        public int? IsActive { get; set; }
    }
}
