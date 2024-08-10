using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssTransferEmpLog
    {
        public decimal Id { get; set; }
        public string? Empcode { get; set; }
        public int? Status { get; set; }
        public string? StatusAd { get; set; }
        public string? TransferedBy { get; set; }
        public string? TransferedTo { get; set; }
        public string? Remark { get; set; }
        public DateTime? TransferedTime { get; set; }
        public DateTime? AcceptedTime { get; set; }
        public string? SubDept { get; set; }
        public string? PreviousSubDept { get; set; }
        public string? Location { get; set; }
    }
}
