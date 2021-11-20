using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class PaymentSchedule
    {
        public PaymentSchedule()
        {
            BasicDetails = new HashSet<BasicDetails>();
            Project = new HashSet<Project>();
        }

        public long Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public int? Days { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
