using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrRecruitmentDetailsLog
    {
        public int Id { get; set; }
        public string? Empcode { get; set; }
        public string? HrManager { get; set; }
        public string? Batchid { get; set; }
        public string? RequestId { get; set; }
        public int? EmpStatus { get; set; }
        public int? IsHrhandOver { get; set; }
        public string? TrainerManager { get; set; }
        public DateTime? HrHandOverDate { get; set; }
        public int? TrainerEmpStatus { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? TmAcceptedDate { get; set; }
        public DateTime? RejectedDate { get; set; }
    }
}
