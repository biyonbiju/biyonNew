using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace MPoolBit.CRMService.Models
{
    public partial class Emirate
    {
        public Emirate()
        {
            BasicDetails = new HashSet<BasicDetails>();
            Crmlead = new HashSet<Crmlead>();
            ProjectDetails = new HashSet<ProjectDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? CountryId { get; set; }
        public short? IsDeleted { get; set; }
        public string ExtensionCode { get; set; }

        public virtual Country Country { get; set; }
        [JsonIgnore]
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> Crmlead { get; set; }
        [JsonIgnore]

        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
    }
}
