using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SupplierTimeCardHeader
    {
        public SupplierTimeCardHeader()
        {
            SupplierTimeCard = new HashSet<SupplierTimeCard>();
        }

        public long Id { get; set; }
        public long? SupplierId { get; set; }
        public long? EmployeeId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public int? Month { get; set; }
        public short? IsDeleted { get; set; }
        public int? Year { get; set; }

        public virtual User Employee { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual User Supplier { get; set; }
        public virtual ICollection<SupplierTimeCard> SupplierTimeCard { get; set; }
    }
}
