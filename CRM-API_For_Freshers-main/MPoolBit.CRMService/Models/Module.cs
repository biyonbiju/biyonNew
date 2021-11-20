using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Module
    {
        public Module()
        {
            ActivityLog = new HashSet<ActivityLog>();
            InverseParant = new HashSet<Module>();
            Notification = new HashSet<Notification>();
            Permission = new HashSet<Permission>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? ParantId { get; set; }
        public long? SubMenuId { get; set; }

        public virtual Module Parant { get; set; }
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<Module> InverseParant { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<Permission> Permission { get; set; }
    }
}
