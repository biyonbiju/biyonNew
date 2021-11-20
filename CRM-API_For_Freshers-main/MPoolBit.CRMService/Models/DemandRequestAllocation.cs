using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class DemandRequestAllocation
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? DemandRequestId { get; set; }
        public short? IsDeleted { get; set; }
        public short? IsAllocated { get; set; }
        public long? TradeChangeAsId { get; set; }

        public virtual DemandRequest DemandRequest { get; set; }
        public virtual User Employee { get; set; }
        public virtual Designation TradeChangeAs { get; set; }
    }
}
