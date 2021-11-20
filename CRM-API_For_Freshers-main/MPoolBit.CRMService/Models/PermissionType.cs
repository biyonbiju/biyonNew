using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            Permission = new HashSet<Permission>();
        }

        public long Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
    }
}
