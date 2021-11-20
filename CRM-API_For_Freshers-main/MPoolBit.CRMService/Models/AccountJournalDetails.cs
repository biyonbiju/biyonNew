using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountJournalDetails
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? CostCentreId { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public long? AccountJournalId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountJournal AccountJournal { get; set; }
        public virtual CostCategory CostCentre { get; set; }
    }
}
