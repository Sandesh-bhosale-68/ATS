using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class WarningHistory
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
    }
}
