using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientInvoiceReference
    {
        public long Id { get; set; }
        public long? ReferenceHeadId { get; set; }
        public string Remarks { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual InvoiceReferenceHeadType ReferenceHead { get; set; }
    }
}
