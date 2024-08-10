using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvEmployeeFeedback
    {
        public long EfId { get; set; }
        public long SrvId { get; set; }
        public long QId { get; set; }
        public byte[]? EmpCode { get; set; }
        public string? Answer { get; set; }
        public byte[]? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
