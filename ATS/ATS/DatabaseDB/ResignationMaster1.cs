using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ResignationMaster1
    {
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public DateTime? ResignDate { get; set; }
        public string? ResignReason { get; set; }
        public string? ResignRemarks { get; set; }
        public DateTime? RevokeDate { get; set; }
        public string? RevokeReason { get; set; }
        public string? MgrCode { get; set; }
        public string? MgrStatus { get; set; }
        public string? MgrEmailId { get; set; }
        public DateTime? MgrUpdatedDate { get; set; }
        public DateTime? LastworkingDay { get; set; }
        public int? NoticePeriod { get; set; }
        public string? MgrRejectedReason { get; set; }
        public string? Hropo { get; set; }
        public int? Hrstatus { get; set; }
        public DateTime? HrupdatedDate { get; set; }
        public string? HrrejectedReason { get; set; }
        public int? HrextendedDays { get; set; }
        public string? HrextendedReason { get; set; }
        public int? Tlstatus { get; set; }
        public int? MgStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Approved { get; set; }
        public bool? MainMgStatus { get; set; }
        public bool? IagreeForExtendDt { get; set; }
        public bool? EmpStatus { get; set; }
    }
}
