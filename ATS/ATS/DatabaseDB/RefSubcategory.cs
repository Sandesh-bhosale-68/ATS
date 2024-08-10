using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefSubcategory
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string? SubCategory { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
