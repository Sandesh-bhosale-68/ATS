using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class MomEmpDatum
    {
        public long Id { get; set; }
        public string? EmpCode { get; set; }
        public int? QuestionCode { get; set; }
        public string? AnswerValue { get; set; }
        public int? AnswerRate { get; set; }
        public bool? IsAttempted { get; set; }
        public DateTime? RecDate { get; set; }
        public string? Day { get; set; }
        public bool? IsActive { get; set; }
    }
}
