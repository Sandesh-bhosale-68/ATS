using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblEmpMaster
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public DateTime? LastWorkingDate { get; set; }
    }
}
