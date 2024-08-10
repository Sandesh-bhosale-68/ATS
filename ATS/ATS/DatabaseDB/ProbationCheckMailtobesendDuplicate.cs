using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ProbationCheckMailtobesendDuplicate
    {
        public int Id { get; set; }
        public string? Empcode { get; set; }
        public int? ExtensionDays { get; set; }
        public string? Empname { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? IsmailSend { get; set; }
    }
}
