using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SupplierInvoiceDetails
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? ProjectId { get; set; }
        public int? Hours { get; set; }
        public decimal? Rate { get; set; }
        public short? IsDeleted { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public long? DesignationId { get; set; }
        public int? AbsentDays { get; set; }
        public decimal? HotHrs { get; set; }
        public decimal? NotHrs { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? NotRate { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual User Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
