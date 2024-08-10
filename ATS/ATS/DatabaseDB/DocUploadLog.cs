using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DocUploadLog
    {
        public int Id { get; set; }
        public string? DocName { get; set; }
        public string? DocCategory { get; set; }
        public string? EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? FileName { get; set; }
        public string? Uploadedpath { get; set; }
        public string? UploadedBy { get; set; }
        public string? MachineIp { get; set; }
        public DateTime? UploadedDate { get; set; }
        public int? LocationId { get; set; }
        public string? LocationName { get; set; }
        public int? DocCategoryId { get; set; }
    }
}
