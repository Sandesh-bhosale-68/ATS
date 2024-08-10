using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class FormMaster
    {
        public int FormId { get; set; }
        public string? Name { get; set; }
        public string? FormName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
