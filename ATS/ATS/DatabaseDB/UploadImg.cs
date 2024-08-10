using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UploadImg
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? PhotoPath { get; set; }
        public int? LocationId { get; set; }
        public string? UploadBy { get; set; }
        public bool? Status { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
