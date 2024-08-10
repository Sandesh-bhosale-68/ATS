using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UploadWarning
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Type { get; set; }
        public string? Warning { get; set; }
        public string? SystemIp { get; set; }
        public string? UploadBy { get; set; }
        public int? LocationId { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
