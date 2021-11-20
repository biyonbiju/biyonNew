using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class StaffSalaryHeader
    {
        public StaffSalaryHeader()
        {
            StaffSalary = new HashSet<StaffSalary>();
        }

        public long Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public DateTime? PayDate { get; set; }
        public string RefNo { get; set; }
        public long? UserRoleCategoryId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual UserRoleCategory UserRoleCategory { get; set; }
        public virtual ICollection<StaffSalary> StaffSalary { get; set; }
    }
}
