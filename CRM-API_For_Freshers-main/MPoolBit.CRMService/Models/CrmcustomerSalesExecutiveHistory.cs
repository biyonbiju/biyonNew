using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmcustomerSalesExecutiveHistory
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? SalesExecutiveId { get; set; }
        public DateTime? Date { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual User Customer { get; set; }
        public virtual User SalesExecutive { get; set; }
    }
}
