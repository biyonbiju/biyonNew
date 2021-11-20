using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientInvoiceExpense
    {
        public long Id { get; set; }
        public long? ExpenseId { get; set; }
        public decimal? Amount { get; set; }
        public short? IsDeleted { get; set; }
        public long? AccountUserInvoiceId { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual InvoiceExpenseType Expense { get; set; }
    }
}
