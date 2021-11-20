using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Eidstatus
    {
        public Eidstatus()
        {
            MedicalDetails = new HashSet<MedicalDetails>();
            UserDetailsCicpaStatus = new HashSet<UserDetails>();
            UserDetailsDrivingLicenceStatus = new HashSet<UserDetails>();
            UserDetailsEidstatus = new HashSet<UserDetails>();
            UserDetailsInsuranceCardStatus = new HashSet<UserDetails>();
            UserDetailsLabourCardStatus = new HashSet<UserDetails>();
            UserDocument = new HashSet<UserDocument>();
        }

        public long Id { get; set; }
        public string Eidstatus1 { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<MedicalDetails> MedicalDetails { get; set; }
        public virtual ICollection<UserDetails> UserDetailsCicpaStatus { get; set; }
        public virtual ICollection<UserDetails> UserDetailsDrivingLicenceStatus { get; set; }
        public virtual ICollection<UserDetails> UserDetailsEidstatus { get; set; }
        public virtual ICollection<UserDetails> UserDetailsInsuranceCardStatus { get; set; }
        public virtual ICollection<UserDetails> UserDetailsLabourCardStatus { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
    }
}
