using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssReferFrnd
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ContactNo { get; set; }
        public string? Qualification { get; set; }
        public string? Experience { get; set; }
        public string? RequestBy { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
