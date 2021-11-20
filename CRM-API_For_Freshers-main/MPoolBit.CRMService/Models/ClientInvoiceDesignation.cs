using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientInvoiceDesignation
    {
        public long Id { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public long? DesignationId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
