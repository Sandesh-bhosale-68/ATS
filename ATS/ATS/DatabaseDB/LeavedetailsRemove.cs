using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LeavedetailsRemove
    {
        public decimal Id { get; set; }
        public string? Empcode { get; set; }
        public string? FromDate { get; set; }
        public string? Todate { get; set; }
        public int? CompOff { get; set; }
        public int? WeekOff { get; set; }
        public DateTime? ReqDate { get; set; }
        public decimal? PaidLeaves { get; set; }
        public decimal? Lwp { get; set; }
        public decimal? PendingLeaves { get; set; }
        public string? SancDate { get; set; }
        public string? SancBy { get; set; }
        public string? Status { get; set; }
        public string? RequestId { get; set; }
        public decimal? CancelRequest { get; set; }
    }
}
