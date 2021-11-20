using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SalaryDetails
    {
        public long Id { get; set; }
        public decimal? Basic { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? SpecialAllowance { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? TelephoneAllowance { get; set; }
        public DateTime? Date { get; set; }
        public long? UserId { get; set; }
        public decimal? HourRate { get; set; }
        public short? IsDeleted { get; set; }
        public decimal? AccomadationAllowance { get; set; }
        public decimal? TransportationAllowance { get; set; }
        public decimal? FoodAllowance { get; set; }
        public short? IsHourlyRate { get; set; }
        public decimal? HourlyRate { get; set; }
        public long? SalaryHeadId { get; set; }

        public virtual SalaryHead SalaryHead { get; set; }
        public virtual User User { get; set; }
    }
}
