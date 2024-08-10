using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ConfirmationList
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? LocationId { get; set; }
        public DateTime? Doc { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Systemname { get; set; }
    }
}
