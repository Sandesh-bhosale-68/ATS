using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpcodeMissing
    {
        public string? TemporaryEmpCode { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? EmpCodeLm { get; set; }
        public byte? Activeemp { get; set; }
    }
}
