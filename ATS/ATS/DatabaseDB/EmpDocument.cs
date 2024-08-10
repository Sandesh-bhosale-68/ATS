using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpDocument
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public int? DocTypeId { get; set; }
        public int? SubDocTypeId { get; set; }
        public string? UploadedPath { get; set; }
        public DateTime? WhenEntered { get; set; }
        public DateTime? WhenModified { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsApproved { get; set; }
    }
}
