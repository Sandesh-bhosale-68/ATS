using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ResignationMaster
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpReason { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string? EmpCodeLm { get; set; }
        public bool? ApproveStatus { get; set; }
        public string? EmpCodeLmreason { get; set; }
        public int? NoticePeriod { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public DateTime? WhenEntered { get; set; }
        public DateTime? WhenModified { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsRetain { get; set; }
        public DateTime? RetainDate { get; set; }
        public int? ExtendOrShortfallDays { get; set; }
        public string? IsExtendOrShortfall { get; set; }
        public string? Comments { get; set; }
    }
}
