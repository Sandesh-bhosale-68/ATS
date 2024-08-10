using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DeptTable20230614
    {
        public int Id { get; set; }
        public string? DeptName { get; set; }
        public string? SubDeptName { get; set; }
        public int? DeptId { get; set; }
        public int? LocationId { get; set; }
        public string? DbName { get; set; }
        public string? DbUserName { get; set; }
        public string? DbPassword { get; set; }
        public string? TableName { get; set; }
        public string? ServerIp { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? TrainingPaid { get; set; }
        public decimal? TrainingDays { get; set; }
        public decimal? CertificationDays { get; set; }
        public string? CallcenterType { get; set; }
        public string? Abbrevation { get; set; }
        public string? VerticalName { get; set; }
        public string? ContractCode { get; set; }
        public string? SubContractL1 { get; set; }
        public string? SubContractL2 { get; set; }
    }
}
