using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvAccessTypeD
    {
        public int AccessTypeId { get; set; }
        public string? AccessType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Urllink { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public long? SrvId { get; set; }
    }
}
