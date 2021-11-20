using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class InvoiceExpenseType
    {
        public InvoiceExpenseType()
        {
            ClientInvoiceExpense = new HashSet<ClientInvoiceExpense>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<ClientInvoiceExpense> ClientInvoiceExpense { get; set; }
    }
}
