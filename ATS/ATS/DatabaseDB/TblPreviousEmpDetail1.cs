using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblPreviousEmpDetail1
    {
        public decimal Id { get; set; }
        public decimal? Masterid { get; set; }
        public string? Companyname { get; set; }
        public string? Designation { get; set; }
        public DateTime? Fromdt { get; set; }
        public DateTime? Todt { get; set; }
        public string? ExpectedCtc { get; set; }
        public string? Empcode { get; set; }
    }
}
