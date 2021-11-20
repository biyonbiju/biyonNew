using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SisterConcernCompanies
    {
        public SisterConcernCompanies()
        {
            InverseParent = new HashSet<SisterConcernCompanies>();
        }

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? ParentId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual User Customer { get; set; }
        public virtual SisterConcernCompanies Parent { get; set; }
        public virtual ICollection<SisterConcernCompanies> InverseParent { get; set; }
    }
}
