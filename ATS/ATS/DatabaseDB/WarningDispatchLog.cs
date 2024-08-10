using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class WarningDispatchLog
    {
        public int WarningDispatchId { get; set; }
        public string? EmployeeCode { get; set; }
        public string? EmployeeLmanagerCode { get; set; }
        public string? Type { get; set; }
        public string? Warning { get; set; }
        public string? Departmnet { get; set; }
        public string? Designation { get; set; }
        public string? CurrentLocation { get; set; }
        public string? Remark { get; set; }
        public DateTime? WarningDate { get; set; }
        public bool? WarningStatus { get; set; }
        public bool? WarningHrStatus { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool? Reject { get; set; }
        public int? LevelId { get; set; }
        public string? EmpName { get; set; }
        public string? SubDept { get; set; }
        public string? UploadBy { get; set; }
    }
}
