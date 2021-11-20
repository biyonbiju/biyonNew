using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientInvoiceProject
    {
        public long Id { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public long? ProjectId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual Project Project { get; set; }
    }
}
