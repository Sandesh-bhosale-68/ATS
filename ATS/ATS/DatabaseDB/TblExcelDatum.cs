using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblExcelDatum
    {
        public string? EmpCode { get; set; }
        public DateTime? ResignationDate { get; set; }
        public int? NoticePeriod { get; set; }
        public DateTime? LastWorkingDate { get; set; }
    }
}
