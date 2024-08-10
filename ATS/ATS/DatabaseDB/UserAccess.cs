using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UserAccess
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Title { get; set; }
        public string? EmpCode { get; set; }
        public string? AccessRole { get; set; }
        public string? Password { get; set; }
    }
}
