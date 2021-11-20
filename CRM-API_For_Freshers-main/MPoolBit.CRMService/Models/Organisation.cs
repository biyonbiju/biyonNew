using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Organisation
    {
        public Organisation()
        {
            Branch = new HashSet<Branch>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? LogoId { get; set; }
        public string TrnNo { get; set; }
        public string ShortName { get; set; }
        public short? IsActive { get; set; }
        public short? IsDeleted { get; set; }
        public string Address { get; set; }
        public long? FinancialPeriodId { get; set; }

        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual Attachment Logo { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
    }
}
