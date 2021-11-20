using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class WorkCategory
    {

        public WorkCategory()
        {
            Crmlead = new HashSet<Crmlead>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Crmlead> Crmlead { get; set; }
    }
}
