using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpComplaintsTran
    {
        public int Id { get; set; }
        public int? TicketNo { get; set; }
        public string? SalaryHead { get; set; }
        public string? Issue { get; set; }
        public string? HrFeedback { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
