using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class KnownTrade
    {
        public long Id { get; set; }
        public long? DesignationId { get; set; }
        public string PerPercentageKnown { get; set; }
        public long? UserId { get; set; }
        public short? IsDeleted { get; set; }
        public decimal? Rate { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual User User { get; set; }
    }
}
