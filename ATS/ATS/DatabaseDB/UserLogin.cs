using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Usertype { get; set; }
        public int? Isactive { get; set; }
        public string? Empid { get; set; }
        public string? Location { get; set; }
    }
}
