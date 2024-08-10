using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpmasterResignationUpdateLog
    {
        public string? LoginD { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Empcode { get; set; }
        public string? ResignationDate { get; set; }
        public string? Type { get; set; }
    }
}
