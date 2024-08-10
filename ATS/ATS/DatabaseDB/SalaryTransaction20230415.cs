using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SalaryTransaction20230415
    {
        public int Id { get; set; }
        public DateTime SalaryMonth { get; set; }
        public string? CardNo { get; set; }
        public string EmpCode { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public DateTime Doj { get; set; }
        public string? Department { get; set; }
        public string? Process { get; set; }
        public string? Location { get; set; }
        public string? StateName { get; set; }
        public string? Designation { get; set; }
        public string? BankName { get; set; }
        public string? BankAccount { get; set; }
        public string? RefNo { get; set; }
        public double? DaysPresent { get; set; }
        public string? DaysPaid { get; set; }
        public double? PaidLeave { get; set; }
        public double? DaysWoff { get; set; }
        public double? DaysPdOff { get; set; }
        public double? DaysLwp { get; set; }
        public double? DaysAbsent { get; set; }
        public string? ArrearsDays { get; set; }
        public double? Lvpldays { get; set; }
        public double? Basic { get; set; }
        public double? ArrearsBasic { get; set; }
        public double? Hra { get; set; }
        public double? ArrearsHra { get; set; }
        public double? Cca { get; set; }
        public double? ArrearsCca { get; set; }
        public double? Conveyance { get; set; }
        public double? ArrearsConveyance { get; set; }
        public double? VarAllowance { get; set; }
        public double? ArrearsVarAllowence { get; set; }
        public double? FoodAllowance { get; set; }
        public double? ArrearsFoodAllowance { get; set; }
        public double? MedicalAllowance { get; set; }
        public double? ArrearsMediacalAllowance { get; set; }
        public double? EduAllowance { get; set; }
        public double? ArrearsEduAllwance { get; set; }
        public double? MobReimAllowance { get; set; }
        public double? ArrearsMobReimAllowance { get; set; }
        public double? Sodexo { get; set; }
        public double? TravelAllowance { get; set; }
        public double? TaPetrol { get; set; }
        public double? Other { get; set; }
        public double? InsentiveAdjustment { get; set; }
        public double? Lvplamt { get; set; }
        public double? GrossSalary { get; set; }
        public double? Pf { get; set; }
        public double? Esic { get; set; }
        public double? Pt { get; set; }
        public double? Tds { get; set; }
        public double? It { get; set; }
        public double? IcardCharges { get; set; }
        public double? OtherDeduction { get; set; }
        public double? Advance { get; set; }
        public double? AcOpChrgs { get; set; }
        public double? SodexoDed { get; set; }
        public double? TotalDed { get; set; }
        public double? NetSalary { get; set; }
        public double? Ctc { get; set; }
        public double? Gross { get; set; }
        public double? PenFund { get; set; }
        public double? Emplpf { get; set; }
        public double? Cesic { get; set; }
        public double? Esicgross { get; set; }
        public string? Status { get; set; }
        public string? Comments { get; set; }
        public double? ProcessPenalty { get; set; }
        public double? Lwf { get; set; }
        public double? Rbicharges { get; set; }
        public double? AttendenceAllowance { get; set; }
        public double? SpecialAllowance { get; set; }
        public double? ArrearSpeAllowance { get; set; }
        public double? TrainingFeeDed { get; set; }
        public double? LastMonthArrear { get; set; }
        public double? AssetDeposit { get; set; }
        public string SalaryMonth1 { get; set; } = null!;
        public double? StBonus { get; set; }
        public DateTime? UploadTime { get; set; }
        public double? ArrearPaid { get; set; }
        public string? Pfaccno { get; set; }
        public double? Lta { get; set; }
        public string? UanNo { get; set; }
        public string? EsicNo { get; set; }
        public double? Miscellaneous { get; set; }
        public double? MedicalInsurance { get; set; }
        public string? Ifsccode { get; set; }
        public double? NoticePeriodRecovery { get; set; }
    }
}
