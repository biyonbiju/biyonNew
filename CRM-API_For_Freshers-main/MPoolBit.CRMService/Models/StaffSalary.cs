using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class StaffSalary
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? Others { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? HalfPay { get; set; }
        public decimal? NoPay { get; set; }
        public decimal? Lop { get; set; }
        public decimal? Pf { get; set; }
        public decimal? Esi { get; set; }
        public decimal? Not { get; set; }
        public decimal? Pot { get; set; }
        public decimal? FixedAdditions { get; set; }
        public decimal? OtherAdditions { get; set; }
        public decimal? FixedDeduction { get; set; }
        public decimal? OtherDeduction { get; set; }
        public decimal? Advance { get; set; }
        public decimal? EncashDays { get; set; }
        public decimal? EncashAmount { get; set; }
        public decimal? TotalAdditions { get; set; }
        public decimal? TotalDeductions { get; set; }
        public string Remarks { get; set; }
        public long? StaffSalaryHeaderId { get; set; }

        public virtual User Employee { get; set; }
        public virtual StaffSalaryHeader StaffSalaryHeader { get; set; }
    }
}
