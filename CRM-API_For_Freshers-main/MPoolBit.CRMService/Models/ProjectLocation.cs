using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectLocation
    {
        public ProjectLocation()
        {
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? LocationId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Location Location { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
    }
}
