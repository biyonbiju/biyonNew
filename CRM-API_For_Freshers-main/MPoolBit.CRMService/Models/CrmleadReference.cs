using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class CrmleadReference
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public long? CrmleadId { get; set; }
        public short? IsDeleted { get; set; }
        public long? DesignationId { get; set; }
        public short? DefaultContact { get; set; }
		public long? CustomerReferenceId { get; set; }
        public virtual Designation Designation { get; set; }
        [JsonIgnore]

        public virtual Crmlead Crmlead { get; set; }
		public virtual UserRefrence CustomerReference { get; set; }
    }
}
