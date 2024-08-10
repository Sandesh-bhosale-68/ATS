using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InvIssueTrackerRemove
    {
        public int Id { get; set; }
        public string? IssueType { get; set; }
        public string? Process { get; set; }
        public string? Problem { get; set; }
        public string? Solution { get; set; }
        public string? AddedBy { get; set; }
        public string? MachineName { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
