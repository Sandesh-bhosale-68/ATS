using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SmsItList
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Number { get; set; } = null!;
        public string? LocationId { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
