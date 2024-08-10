using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DocumentDetail
    {
        public int Id { get; set; }
        public string? DocType { get; set; }
        public int? ParentId { get; set; }
        public DateTime? WhenEntered { get; set; }
    }
}
