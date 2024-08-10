using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TrainingAccess
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}
