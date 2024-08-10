using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblReference
    {
        public decimal Id { get; set; }
        public decimal? Masterid { get; set; }
        public string? Refname { get; set; }
        public string? Refcontact { get; set; }
        public string? Refcurremp { get; set; }
        public string? Refdesig { get; set; }
        public string? Empcode { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
