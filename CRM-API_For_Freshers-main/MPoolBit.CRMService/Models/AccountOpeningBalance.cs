using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountOpeningBalance
    {
        public AccountOpeningBalance()
        {
            AccountOpeningBalanceDetails = new HashSet<AccountOpeningBalanceDetails>();
        }

        public long Id { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public short? IsDeleted { get; set; }

        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AccountOpeningBalanceDetails> AccountOpeningBalanceDetails { get; set; }
    }
}
