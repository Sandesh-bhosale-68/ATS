using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AmTrainerMaster
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Empcode { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? EmpcodeLm { get; set; }
        public string? TrainingDesignation { get; set; }
    }
}
