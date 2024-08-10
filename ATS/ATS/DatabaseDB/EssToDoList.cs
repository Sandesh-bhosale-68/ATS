using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssToDoList
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
