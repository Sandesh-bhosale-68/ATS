using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssEmpOpening
    {
        public int Id { get; set; }
        public string? OpeningSection { get; set; }
        public string? JobCategory { get; set; }
        public string? Title { get; set; }
        public string? Profile { get; set; }
        public string? Qualification { get; set; }
        public string? Experience { get; set; }
        public int? LocationId { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
