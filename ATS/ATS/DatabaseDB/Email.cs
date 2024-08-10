using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Email
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Subject { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string? Body { get; set; }
    }
}
