using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class InvoiceReferenceHeadType
    {
        public InvoiceReferenceHeadType()
        {
            ClientInvoiceReference = new HashSet<ClientInvoiceReference>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<ClientInvoiceReference> ClientInvoiceReference { get; set; }
    }
}
