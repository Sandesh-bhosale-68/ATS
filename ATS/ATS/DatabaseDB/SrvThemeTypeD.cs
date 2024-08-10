using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvThemeTypeD
    {
        public long ThemeId { get; set; }
        public string? ThemeCode { get; set; }
        public string? ThemeName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public long? SrvId { get; set; }
    }
}
