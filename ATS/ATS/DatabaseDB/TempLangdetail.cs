using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TempLangdetail
    {
        public decimal Id { get; set; }
        public decimal? Masterid { get; set; }
        public decimal? Empcode { get; set; }
        public string? Language { get; set; }
        public string? Speak { get; set; }
        public string? Read { get; set; }
        public string? Write { get; set; }
        public string? Machinename { get; set; }
    }
}
