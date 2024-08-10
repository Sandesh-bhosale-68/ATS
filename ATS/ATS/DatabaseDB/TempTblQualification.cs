using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TempTblQualification
    {
        public int Id { get; set; }
        public int? Masterid { get; set; }
        public string? Yrofpass { get; set; }
        public string? Board { get; set; }
        public string? Percentage { get; set; }
        public string? QualiLevel { get; set; }
        public string? Stream { get; set; }
        public string? AnyOther { get; set; }
        public string? SessionId { get; set; }
    }
}
