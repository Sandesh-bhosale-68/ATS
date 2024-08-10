using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblTelephonicInterview
    {
        public decimal Id { get; set; }
        public string? Empname { get; set; }
        public string? Empcode { get; set; }
        public string? Location { get; set; }
        public int? LocationId { get; set; }
    }
}
