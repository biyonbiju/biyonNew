using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class DemandRequestTrades
    {
        public long Id { get; set; }
        public long? TradeId { get; set; }
        public long? DemandRequestId { get; set; }
        public short? IsDeleted { get; set; }
        public int? Quantity { get; set; }
        public string TypeOfWork { get; set; }

        public virtual DemandRequest DemandRequest { get; set; }
        public virtual Designation Trade { get; set; }
    }
}
