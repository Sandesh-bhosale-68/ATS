using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Poshresult
    {
        public long Id { get; set; }
        public string? Opoid { get; set; }
        public string? Resultstatus { get; set; }
        public DateTime? Resultdate { get; set; }
    }
}
