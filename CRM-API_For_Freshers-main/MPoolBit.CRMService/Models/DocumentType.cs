using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            AccountUserInvoiceDocument = new HashSet<AccountUserInvoiceDocument>();
            BranchDocument = new HashSet<BranchDocument>();
            Notification = new HashSet<Notification>();
            ProjectDocument = new HashSet<ProjectDocument>();
            SponsorshipCompanyDocument = new HashSet<SponsorshipCompanyDocument>();
            UserDocument = new HashSet<UserDocument>();
            CrmleadDocuments = new HashSet<CrmleadDocuments>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }
        public int? NotificationDays { get; set; }

        public virtual ICollection<AccountUserInvoiceDocument> AccountUserInvoiceDocument { get; set; }
        public virtual ICollection<BranchDocument> BranchDocument { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<ProjectDocument> ProjectDocument { get; set; }
        public virtual ICollection<SponsorshipCompanyDocument> SponsorshipCompanyDocument { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
        public virtual ICollection<CrmleadDocuments> CrmleadDocuments { get; set; }
    }
}
