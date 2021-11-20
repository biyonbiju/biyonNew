using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountNoteAccount
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public decimal? Amount { get; set; }
        public string Narration { get; set; }
        public long? AccountNoteId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountNote AccountNote { get; set; }
    }
}
