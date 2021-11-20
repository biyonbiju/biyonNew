using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Attachment
    {
        public Attachment()
        {
            AccountJournal = new HashSet<AccountJournal>();
            AccountNote = new HashSet<AccountNote>();
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            AccountUserInvoiceDocument = new HashSet<AccountUserInvoiceDocument>();
            BasicDetailsPhoto = new HashSet<BasicDetails>();
            BasicDetailsSignature = new HashSet<BasicDetails>();
            Branch = new HashSet<Branch>();
            BranchDocument = new HashSet<BranchDocument>();
            ClientTimeSheet = new HashSet<ClientTimeSheet>();
            CrmleadCompanyPhoto = new HashSet<Crmlead>();
            CrmleadProjectPhoto = new HashSet<Crmlead>();
            CrmtaskDetail = new HashSet<CrmtaskDetail>();
            MedicalDetails = new HashSet<MedicalDetails>();
            Organisation = new HashSet<Organisation>();
            ProjectDocument = new HashSet<ProjectDocument>();
            RateContractTemplete = new HashSet<RateContractTemplete>();
            SponsorshipCompanyDocument = new HashSet<SponsorshipCompanyDocument>();
            SponsorshipCompanyLogo = new HashSet<SponsorshipCompany>();
            SponsorshipCompanyReportFooter = new HashSet<SponsorshipCompany>();
            SponsorshipCompanyReportHeader = new HashSet<SponsorshipCompany>();
            SponsorshipCompanyStamp = new HashSet<SponsorshipCompany>();
            SponsorshipCompanyWaterMark = new HashSet<SponsorshipCompany>();
            UserDetailsBankDocattachment = new HashSet<UserDetails>();
            UserDetailsCicpaAttachment = new HashSet<UserDetails>();
            UserDetailsDrivingLicenceAttachment = new HashSet<UserDetails>();
            UserDetailsEidattachment = new HashSet<UserDetails>();
            UserDetailsInsuranceCardAttachment = new HashSet<UserDetails>();
            UserDetailsPassportJpegattachment = new HashSet<UserDetails>();
            UserDetailsPassportPdfattachment = new HashSet<UserDetails>();
            UserDetailsPaymentDocAttachment = new HashSet<UserDetails>();
            UserDetailsVisaAttachment = new HashSet<UserDetails>();
            UserDocument = new HashSet<UserDocument>();
            CrmLeadPhoto = new HashSet<Crmlead>();
            CrmleadDocuments = new HashSet<CrmleadDocuments>();
            CrmleadOfficePhoto = new HashSet<Crmlead>();
            CrmleadProjectSitePhoto = new HashSet<Crmlead>();
            SponsorshipCompanyCrmceal = new HashSet<SponsorshipCompany>();
            BasicDetailsOfficePhoto = new HashSet<BasicDetails>();
            BasicDetailsOutsideViewPhoto = new HashSet<BasicDetails>();

        }

        public long Id { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountJournal> AccountJournal { get; set; }
        public virtual ICollection<AccountNote> AccountNote { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<AccountUserInvoiceDocument> AccountUserInvoiceDocument { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsPhoto { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsSignature { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Crmlead> CrmleadOfficePhoto { get; set; }
        public virtual ICollection<Crmlead> CrmleadProjectSitePhoto { get; set; }
        public virtual ICollection<BranchDocument> BranchDocument { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheet { get; set; }
        public virtual ICollection<Crmlead> CrmleadCompanyPhoto { get; set; }
        public virtual ICollection<Crmlead> CrmleadProjectPhoto { get; set; }
        public virtual ICollection<CrmtaskDetail> CrmtaskDetail { get; set; }
        public virtual ICollection<MedicalDetails> MedicalDetails { get; set; }
        public virtual ICollection<Organisation> Organisation { get; set; }
        public virtual ICollection<ProjectDocument> ProjectDocument { get; set; }
        public virtual ICollection<RateContractTemplete> RateContractTemplete { get; set; }
        public virtual ICollection<SponsorshipCompanyDocument> SponsorshipCompanyDocument { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyLogo { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyReportFooter { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyReportHeader { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyStamp { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyWaterMark { get; set; }
        public virtual ICollection<UserDetails> UserDetailsBankDocattachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsCicpaAttachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsDrivingLicenceAttachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsEidattachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsInsuranceCardAttachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsPassportJpegattachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsPassportPdfattachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsPaymentDocAttachment { get; set; }
        public virtual ICollection<UserDetails> UserDetailsVisaAttachment { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
        public virtual ICollection<Crmlead> CrmLeadPhoto { get; set; }
        public virtual ICollection<CrmleadDocuments> CrmleadDocuments { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompanyCrmceal { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsOfficePhoto { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsOutsideViewPhoto { get; set; }

    }
}
