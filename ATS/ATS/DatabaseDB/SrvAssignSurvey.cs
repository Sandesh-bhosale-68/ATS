using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvAssignSurvey
    {
        public long AsId { get; set; }
        public long SrvId { get; set; }
        public long FId { get; set; }
        public byte[]? EmpCode { get; set; }
        public bool? SurveyDone { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
