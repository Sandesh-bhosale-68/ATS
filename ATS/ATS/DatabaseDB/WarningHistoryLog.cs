using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class WarningHistoryLog
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Remarks { get; set; }
        public DateTime? WDate { get; set; }
        public string? WDept { get; set; }
        public string? WSubDept { get; set; }
        public string? WfromEmpCode { get; set; }
        public string? WfromName { get; set; }
        public string? WfromDept { get; set; }
        public string? SuperName { get; set; }
        public DateTime? Doj { get; set; }
        public string? Comment { get; set; }
        public string? WType { get; set; }
        public string? Type { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? WStatus { get; set; }
        public string? WExtendedReason { get; set; }
    }
}
