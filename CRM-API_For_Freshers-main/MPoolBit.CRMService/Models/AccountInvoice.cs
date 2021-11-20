using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountInvoice
    {
        public AccountInvoice()
        {
            AccountInvoiceDetails = new HashSet<AccountInvoiceDetails>();
        }

        public long Id { get; set; }
        public long? TypeId { get; set; }
        public long? PartyNameId { get; set; }
        public long? SponsershipCompanyId { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public long? FinancialPeriodId { get; set; }

        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual User PartyName { get; set; }
        public virtual SponsorshipCompany SponsershipCompany { get; set; }
        public virtual AccountInvoiceType Type { get; set; }
        public virtual ICollection<AccountInvoiceDetails> AccountInvoiceDetails { get; set; }
    }
}
