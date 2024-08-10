using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LeaveMaster
    {
        public int Id { get; set; }
        public string Empcode { get; set; } = null!;
        public decimal? BalanceLeave { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
