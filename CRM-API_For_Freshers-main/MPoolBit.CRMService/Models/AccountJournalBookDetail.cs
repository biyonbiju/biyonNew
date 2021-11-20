using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountJournalBookDetail
    {
        public long Id { get; set; }
        public long? AccountJournalBookId { get; set; }
        public long? AccountId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Narration { get; set; }
        public short? IsDeleted { get; set; }
        public long? CostCategoryId { get; set; }
        public long? ProjectId { get; set; }
        public short? IsTax { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountJournalBook AccountJournalBook { get; set; }
        public virtual CostCategory CostCategory { get; set; }
        public virtual Project Project { get; set; }
    }
}
