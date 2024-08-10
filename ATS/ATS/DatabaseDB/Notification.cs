using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public int? LocationId { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
        public bool? Status { get; set; }
    }
}
