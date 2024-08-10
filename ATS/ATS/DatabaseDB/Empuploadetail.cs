using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Empuploadetail
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? EmpCode { get; set; }
        public DateTime? AttDate { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
    }
}
