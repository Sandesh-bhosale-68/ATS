using System.ComponentModel.DataAnnotations;

namespace ATS.DatabaseDB
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
