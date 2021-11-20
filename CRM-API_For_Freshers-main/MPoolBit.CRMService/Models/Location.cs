using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Location
    {
        public Location()
        {
            BasicDetails = new HashSet<BasicDetails>();
            CrmleadCompanyLocation = new HashSet<Crmlead>();
            CrmleadProjectLocation = new HashSet<Crmlead>();
            ProjectDetails = new HashSet<ProjectDetails>();
            ProjectLocation = new HashSet<ProjectLocation>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public short? IsDeleted { get; set; }

        [JsonIgnore]
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> CrmleadCompanyLocation { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> CrmleadProjectLocation { get; set; }
        [JsonIgnore]

        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<ProjectLocation> ProjectLocation { get; set; }
    }
}
