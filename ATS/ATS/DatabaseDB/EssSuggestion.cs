using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssSuggestion
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Designation { get; set; }
        public string? Location { get; set; }
        public string? Suggestion { get; set; }
        public DateTime? SuggestedDate { get; set; }
    }
}
