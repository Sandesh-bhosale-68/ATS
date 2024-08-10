using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InvProcessRemove
    {
        public int Id { get; set; }
        public string? Process { get; set; }
        public string? LocationId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
