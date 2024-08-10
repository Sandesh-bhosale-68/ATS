using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblRole
    {
        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string Hr { get; set; } = null!;
        public string Admin { get; set; } = null!;
        public string Manager { get; set; } = null!;
        public string Employee { get; set; } = null!;
        public string CustomUser { get; set; } = null!;
    }
}
