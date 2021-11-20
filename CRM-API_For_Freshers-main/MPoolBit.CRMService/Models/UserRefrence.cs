using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace MPoolBit.CRMService.Models
{
    public partial class UserRefrence
    {

		public UserRefrence()
        {
            Crmleadreference = new HashSet<CrmleadReference>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public long? UserId { get; set; }
        public short? IsDeleted { get; set; }
        public long? DesignationId { get; set; }
        public long? SalutationId { get; set; }

        public virtual Designation Designation { get; set; }
        [JsonIgnore]

        public virtual User User { get; set; }
        public virtual ICollection<CrmleadReference> Crmleadreference { get; set; }
    }
}
