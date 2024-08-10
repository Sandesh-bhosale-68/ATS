using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SystemAdminActivityNew
    {
        public int Id { get; set; }
        public string? Empcode { get; set; }
        public string? Department { get; set; }
        public string? SubDept { get; set; }
        public string? EmpcodeLm { get; set; }
        public string? WindowsId { get; set; }
        public string? EmailId { get; set; }
        public string? SparkId { get; set; }
        public byte? EmailId0nr1r { get; set; }
        public byte? WindowsId0nr1r { get; set; }
        public string? SparkId0nr1r { get; set; }
        public int? LocationId { get; set; }
        public string? UpdatedBy { get; set; }
        public string? MachinName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
