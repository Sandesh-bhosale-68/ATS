using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvAccessMasterD
    {
        public int Id { get; set; }
        public string? OpoId { get; set; }
        public int? AccessTypeId { get; set; }
        public long? LocationId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
