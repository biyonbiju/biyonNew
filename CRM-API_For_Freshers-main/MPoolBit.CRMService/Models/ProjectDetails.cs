using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectDetails
    {
        public ProjectDetails()
        {
            Project = new HashSet<Project>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public long? CoOrdinatorId { get; set; }
        public decimal? NormalHours { get; set; }
        public long? AccomadationTypeId { get; set; }
        public decimal? AllowableAbsence { get; set; }
        public long? AccoumadationEmiratesId { get; set; }
        public string Xcordinates { get; set; }
        public string Ycordinates { get; set; }
        public long? ProjectLocationId { get; set; }
        public short? IsFlat { get; set; }
        public short? IsOverTime { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }
        public long? DesignationId { get; set; }
        public string Gpsxcordinates { get; set; }
        public string Gpsycordinates { get; set; }

        public virtual AccomodationType AccomadationType { get; set; }
        public virtual Emirate AccoumadationEmirates { get; set; }
        public virtual User CoOrdinator { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Location ProjectLocation { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
