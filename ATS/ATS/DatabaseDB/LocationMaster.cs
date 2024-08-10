using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LocationMaster
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; } = null!;
        public string? FolderPath { get; set; }
        public string? NewPath { get; set; }
        public string? Path { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Locationcode { get; set; }
    }
}
