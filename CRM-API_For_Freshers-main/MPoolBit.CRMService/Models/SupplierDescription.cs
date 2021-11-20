using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SupplierDescription
    {
        public SupplierDescription()
        {
            UserDocument = new HashSet<UserDocument>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserDocument> UserDocument { get; set; }
    }
}
