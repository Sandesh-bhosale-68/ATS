using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InvCrmDetailsRemove
    {
        public int Id { get; set; }
        public string? LocationId { get; set; }
        public string? DepartmentId { get; set; }
        public string? SubDepartmentName { get; set; }
        public string? CodePath { get; set; }
        public string? CrmLink { get; set; }
        public string? DatabaseName { get; set; }
        public string? ServerName { get; set; }
        public string? Description { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
