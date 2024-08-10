using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DocAbbrv
    {
        public int Id { get; set; }
        public string? DocCode1 { get; set; }
        public string? DocCode2 { get; set; }
        public string? DocAbbriviation { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DocCategoryId { get; set; }
        public string? DocCategory { get; set; }
    }
}
