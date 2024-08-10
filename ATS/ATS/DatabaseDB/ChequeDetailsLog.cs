using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ChequeDetailsLog
    {
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? ChequeUploadMonth { get; set; }
        public string? ChequeUploadStatus { get; set; }
        public string? ChequeGivenStatus { get; set; }
        public string? ChequeRemark { get; set; }
        public string? ChequeGivenBy { get; set; }
        public string? SystemIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? EmpStatus { get; set; }
    }
}
