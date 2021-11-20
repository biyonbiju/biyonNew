using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class BasicDetails
    {
        public BasicDetails()
        {
            User = new HashSet<User>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public long? BloodGroupId { get; set; }
        public DateTime? JoinDate { get; set; }
        public long? ReligionId { get; set; }
        public long? CountryId { get; set; }
        public string EmailId { get; set; }
        public string LocalCompanyMobileNo { get; set; }
        public string MobileNo { get; set; }
        public string Remarks { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNo { get; set; }
        public string HomeContactName { get; set; }
        public string HomeContactNo { get; set; }
        public long? PhotoId { get; set; }
        public long? CurrencyId { get; set; }
        public string Trn { get; set; }
        public long? AccountId { get; set; }
        public long? CategoryId { get; set; }
        public string FaxNumber { get; set; }
        public long? EmiratesId { get; set; }
        public long? BranchId { get; set; }
        public string Address { get; set; }
        public long? AdvanceAccountId { get; set; }
        public string Age { get; set; }
        public string CardNumber { get; set; }
        public long? DistrictId { get; set; }
        public long? LocationId { get; set; }
        public string MaritalStatus { get; set; }
        public long? PaymentScheduleId { get; set; }
        public long? CreatedBy { get; set; }        
        public string Pobox { get; set; }
        public long? StateId { get; set; }
        public string TelephoneNo { get; set; }
        public long? SupplierId { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public string IncorporatedName { get; set; }
        public string PreviousId { get; set; }
        public string CardNo { get; set; }
        public DateTime? MobilizedDate { get; set; }
        public DateTime? DeMobilizeDate { get; set; }
        public string Website { get; set; }
        public string MolPersonCode { get; set; }
        public long? UserRoleCategoryId { get; set; }
        public string LocalContactAddress { get; set; }
        public string HomeContactAddress { get; set; }
        public string EmergencyContactAddress { get; set; }
        public long? InactiveReasonId { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public long? SignatureId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? SalesExecutiveId { get; set; }
        public decimal? SalesTarget { get; set; }
		public long? OfficePhotoId { get; set; }
        public long? OutsideViewPhotoId { get; set; }
        public long? CommentId { get; set; }
        public short? IsOwnLead { get; set; }
        public long? SalutationId { get; set; }
        public string MakaniNumber { get; set; }
        public long? StatusId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public virtual Account Account { get; set; }
        public virtual Account AdvanceAccount { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual UserCategory Category { get; set; }
        public virtual Country Country { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual District District { get; set; }
        public virtual Emirate Emirates { get; set; }
        public virtual InactiveReason InactiveReason { get; set; }
        public virtual Location Location { get; set; }
        public virtual PaymentSchedule PaymentSchedule { get; set; }
        public virtual Attachment Photo { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual Attachment Signature { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual State State { get; set; }
        public virtual User Supplier { get; set; }
        public virtual UserRoleCategory UserRoleCategory { get; set; }
        public virtual User SalesExecutive { get; set; }
        public virtual ICollection<User> User { get; set; }
		public virtual Attachment OfficePhoto { get; set; }
        public virtual Attachment OutsideViewPhoto { get; set; }
        public virtual CrmleadComments Comment { get; set; }

    }
}
