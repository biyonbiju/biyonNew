using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ContractSalaryDetails
    {
        public long Id { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? SpecialAllowance { get; set; }
        public decimal? TelephoneAllowance { get; set; }
        public DateTime? Date { get; set; }
        public long? UserId { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? TransportAllowance { get; set; }
        public short? IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}
