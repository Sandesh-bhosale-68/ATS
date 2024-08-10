using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssResignationTran
    {
        public int EssResignationTransId { get; set; }
        public int? EssResignationEmpId { get; set; }
        public int? EssResignationLmId { get; set; }
        public int? EssResignationHrId { get; set; }
        public int? EssResignationReasonId { get; set; }
        public DateTime? EssResignationDate { get; set; }
        public DateTime? EssResignationLastDate { get; set; }
        public string? EssResignationEmpRemarks { get; set; }
        public int? EssResignationEmpFlagId { get; set; }
        public int? EssResignationLmFlagId { get; set; }
        public int? EssResignationHrFlagId { get; set; }
        public int? EssResignationLwdDate { get; set; }
        public string? EssResignationLwdRemarks { get; set; }
    }
}
