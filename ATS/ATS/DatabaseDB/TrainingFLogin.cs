using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TrainingFLogin
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Name { get; set; }
        public string? Process { get; set; }
    }
}
