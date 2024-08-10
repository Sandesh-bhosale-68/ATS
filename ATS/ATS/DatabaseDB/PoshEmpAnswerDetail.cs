using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class PoshEmpAnswerDetail
    {
        public long Id { get; set; }
        public string? EmpCode { get; set; }
        public int? QuestionId { get; set; }
        public string? GivenAnswer { get; set; }
        public string? ExpectedAnswer { get; set; }
        public DateTime? RecDate { get; set; }
        public int? Attempt { get; set; }
        public int? Result { get; set; }
    }
}
