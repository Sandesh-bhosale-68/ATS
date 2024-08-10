using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvUserActivity
    {
        public long ActId { get; set; }
        public byte[]? EmpCode { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
