using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrRecruitmentDetail
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
        public string? HoldReason { get; set; }
        public string? RejectReason { get; set; }
        public string? IsTransfertotrainer { get; set; }
        public string? TrainerOpoid { get; set; }
        public string? EmpFinalStatus { get; set; }
        public string? FirstDayRagStatus { get; set; }
        public string? LastDayRagStatus { get; set; }
        public string? RagReason { get; set; }
        public string? OpsManager { get; set; }
        public string? TlOpoid { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? TmAcceptedDate { get; set; }
        public DateTime? RejectedDate { get; set; }
    }
}
