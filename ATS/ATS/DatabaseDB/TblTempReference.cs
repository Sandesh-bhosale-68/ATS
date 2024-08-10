using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblTempReference
    {
        public decimal Id { get; set; }
        public decimal? Masterid { get; set; }
        public string? Refname { get; set; }
        public string? Refcontact { get; set; }
        public string? Refcurremp { get; set; }
        public string? Refdesig { get; set; }
        public string? Domain { get; set; }
        public string? Machinename { get; set; }
    }
}
