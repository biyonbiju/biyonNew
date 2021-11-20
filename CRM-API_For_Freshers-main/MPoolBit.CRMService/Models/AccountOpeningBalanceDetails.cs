using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountOpeningBalanceDetails
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public short? IsDeleted { get; set; }
        public long? AccountOpeningId { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountOpeningBalance AccountOpening { get; set; }
    }
}
