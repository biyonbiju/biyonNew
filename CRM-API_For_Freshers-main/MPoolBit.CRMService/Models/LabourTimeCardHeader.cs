using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class LabourTimeCardHeader
    {
        public LabourTimeCardHeader()
        {
            LabourTimeCard = new HashSet<LabourTimeCard>();
        }

        public long Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public long? EmployeeId { get; set; }
        public short? IsBlockSalary { get; set; }
        public short? IsFinalize { get; set; }
        public decimal? Basic { get; set; }
        public decimal? NormalHrs { get; set; }
        public decimal? NotHrs { get; set; }
        public decimal? HotHrs { get; set; }
        public decimal? TotalHrs { get; set; }
        public decimal? NormalSalary { get; set; }
        public decimal? NotSalary { get; set; }
        public decimal? HotSalary { get; set; }
        public decimal? IncentiveHrs { get; set; }
        public decimal? DeductionHrs { get; set; }
        public decimal? IncentiveAmt { get; set; }
        public decimal? DeductionAmt { get; set; }
        public decimal? PaidDays { get; set; }
        public decimal? Lwp { get; set; }
        public decimal? CasualLeave { get; set; }
        public decimal? LateComing { get; set; }
        public decimal? MedicalLeave { get; set; }
        public decimal? TotalWorked { get; set; }
        public decimal? PaidLeave { get; set; }
        public int? CalenderDays { get; set; }
        public decimal? IncentiveAllowance { get; set; }
        public decimal? WrongDeductionAllowance { get; set; }
        public decimal? PreviousMonthAllowance { get; set; }
        public decimal? ExtraAllowance { get; set; }
        public decimal? AdvanceAllowance { get; set; }
        public decimal? IncentivePayAllowance { get; set; }
        public decimal? WrongDeductionPayAllowance { get; set; }
        public decimal? PreviousMonthPayAllowance { get; set; }
        public decimal? ExtraPayAllowance { get; set; }
        public decimal? AdvancePayAllowance { get; set; }
        public decimal? AbsentFine { get; set; }
        public decimal? IdCard { get; set; }
        public decimal? Fine { get; set; }
        public decimal? WpsExtra { get; set; }
        public decimal? AdvanceDeduction { get; set; }
        public decimal? OtherDeduction { get; set; }
        public decimal? VisaDeduction { get; set; }
        public decimal? WpsChargeDeduction { get; set; }
        public decimal? SalaryBalance { get; set; }
        public decimal? Wps { get; set; }
        public decimal? NonWps { get; set; }
        public decimal? TotalSalary { get; set; }
        public decimal? NetSalary { get; set; }
        public string Remarks { get; set; }
        public short? IsDeleted { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? ProcessingDate { get; set; }

        public virtual User Employee { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual ICollection<LabourTimeCard> LabourTimeCard { get; set; }
    }
}
