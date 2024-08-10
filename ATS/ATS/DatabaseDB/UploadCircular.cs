using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UploadCircular
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public int? LocationId { get; set; }
        public bool? Status { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
