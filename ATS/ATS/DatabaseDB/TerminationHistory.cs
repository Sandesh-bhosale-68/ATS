using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TerminationHistory
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Remarks { get; set; }
        public DateTime? TDate { get; set; }
        public string? TDept { get; set; }
        public string? TSubDept { get; set; }
        public string? TfromEmpCode { get; set; }
        public string? TfromName { get; set; }
        public string? TfromDept { get; set; }
        public string? SuperName { get; set; }
        public DateTime? Doj { get; set; }
        public string? Comment { get; set; }
    }
}
