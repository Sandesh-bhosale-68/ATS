using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class JobTitleMaster
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string JobTitle { get; set; } = null!;
        public int? SupDepartment { get; set; }
        public int? Grade { get; set; }
        public int? IsActive { get; set; }
    }
}
