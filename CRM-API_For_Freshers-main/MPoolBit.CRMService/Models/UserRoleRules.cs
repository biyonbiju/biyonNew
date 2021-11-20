using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserRoleRules
    {
        public UserRoleRules()
        {
            User = new HashSet<User>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
