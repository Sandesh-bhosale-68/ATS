using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class PipHistory
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Remarks { get; set; }
        public string? Target { get; set; }
        public DateTime? PDate { get; set; }
        public string? PDept { get; set; }
        public string? PSubDept { get; set; }
        public string? PipfromEmpCode { get; set; }
        public string? PipfromName { get; set; }
        public string? PipfromDept { get; set; }
        public string? SuperName { get; set; }
        public DateTime? Doj { get; set; }
        public string? Comment { get; set; }
        public string? NotSatisfyFrom { get; set; }
        public string? ImprovementPeriod { get; set; }
        public DateTime? OpenDate { get; set; }
        public string? PipStatus { get; set; }
    }
}
