using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserHistory
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public short? IsBlackListed { get; set; }
        public string Remarks { get; set; }

        public virtual User User { get; set; }
    }
}
