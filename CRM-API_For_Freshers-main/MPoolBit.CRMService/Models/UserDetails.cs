using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            User = new HashSet<User>();
        }

        public long Id { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public long? PassportStatusId { get; set; }
        public DateTime? PassportReleaseDate { get; set; }
        public DateTime? PassportReturnDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public long? PassportPdfattachmentId { get; set; }
        public long? PassportJpegattachmentId { get; set; }
        public string Uidno { get; set; }
        public string VisaNo { get; set; }
        public DateTime? VisaIssueDate { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public string VisaDuration { get; set; }
        public long? VisaTypeId { get; set; }
        public long? VisaAttachmentId { get; set; }
        public long? VisaStatusId { get; set; }
        public long? VisaDesignationId { get; set; }
        public long? VisaSponsorId { get; set; }
        public string Eidno { get; set; }
        public long? EidstatusId { get; set; }
        public DateTime? EidissueDate { get; set; }
        public DateTime? EidexpiryDate { get; set; }
        public long? EidattachmentId { get; set; }
        public long? DrivingLicenceTypeId { get; set; }
        public string DrivingLicenceNo { get; set; }
        public DateTime? DrivingLicenceIssueDate { get; set; }
        public DateTime? DrivingLicenceExpiryDate { get; set; }
        public long? DrivingLicenceAttachmentId { get; set; }
        public string LabourCardPersonalNo { get; set; }
        public string LabourCardNo { get; set; }
        public DateTime? LabourCardIssuueDate { get; set; }
        public DateTime? LabourCardExpiryDate { get; set; }
        public long? PaymentModeId { get; set; }
        public string Ibanno { get; set; }
        public DateTime? CardIssueDate { get; set; }
        public string PaymentCardNo { get; set; }
        public DateTime? CardExpiryDate { get; set; }
        public long? PaymentDocAttachmentId { get; set; }
        public string PaymentRemarks { get; set; }
        public long? InsuranceCardTypeId { get; set; }
        public string InsuranceCardNo { get; set; }
        public DateTime? InsuranceIssueDate { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public long? InsuranceCardAttachmentId { get; set; }
        public string ServiceProvider { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? BankCardIssueDate { get; set; }
        public DateTime? BankCardExpiryDate { get; set; }
        public string BankCardNo { get; set; }
        public long? BankDocattachmentId { get; set; }
        public string PassportPdfFileName { get; set; }
        public string VisaFileName { get; set; }
        public string EidFileName { get; set; }
        public string DrivingLicenceFileName { get; set; }
        public string PaymentDocFileName { get; set; }
        public string InsuranceCardFileName { get; set; }
        public string PassportJpegfileName { get; set; }
        public string BankDocfileName { get; set; }
        public long? DrivingLicenceStatusId { get; set; }
        public long? LabourCardStatusId { get; set; }
        public string CicpaNo { get; set; }
        public long? CicpaStatusId { get; set; }
        public DateTime? CicpaIssueDate { get; set; }
        public DateTime? CicpaExpiryDate { get; set; }
        public long? CicpaAttachmentId { get; set; }
        public long? InsuranceCardStatusId { get; set; }

        public virtual Attachment BankDocattachment { get; set; }
        public virtual Attachment CicpaAttachment { get; set; }
        public virtual Eidstatus CicpaStatus { get; set; }
        public virtual Attachment DrivingLicenceAttachment { get; set; }
        public virtual Eidstatus DrivingLicenceStatus { get; set; }
        public virtual LicenceType DrivingLicenceType { get; set; }
        public virtual Attachment Eidattachment { get; set; }
        public virtual Eidstatus Eidstatus { get; set; }
        public virtual Attachment InsuranceCardAttachment { get; set; }
        public virtual Eidstatus InsuranceCardStatus { get; set; }
        public virtual InsuranceCardType InsuranceCardType { get; set; }
        public virtual Eidstatus LabourCardStatus { get; set; }
        public virtual Attachment PassportJpegattachment { get; set; }
        public virtual Attachment PassportPdfattachment { get; set; }
        public virtual PassportStatus PassportStatus { get; set; }
        public virtual Attachment PaymentDocAttachment { get; set; }
        public virtual PaymentMode PaymentMode { get; set; }
        public virtual Attachment VisaAttachment { get; set; }
        public virtual Designation VisaDesignation { get; set; }
        public virtual VisaSponsor VisaSponsor { get; set; }
        public virtual VisaStatus VisaStatus { get; set; }
        public virtual VisaType VisaType { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
