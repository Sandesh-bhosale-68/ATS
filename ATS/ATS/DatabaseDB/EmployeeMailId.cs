using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmployeeMailId
    {
        public int Id { get; set; }
        public string? OpoId { get; set; }
        public string? EmailId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
