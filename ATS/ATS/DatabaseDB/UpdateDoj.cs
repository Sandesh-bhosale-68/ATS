using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UpdateDoj
    {
        public string? Empcode { get; set; }
        public string? EmpName { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? OphandoverDate { get; set; }
    }
}
