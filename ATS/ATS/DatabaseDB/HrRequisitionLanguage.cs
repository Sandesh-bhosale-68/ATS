using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrRequisitionLanguage
    {
        public int Id { get; set; }
        public string? Languages { get; set; }
        public string? Count { get; set; }
        public string? RequestId { get; set; }
    }
}
