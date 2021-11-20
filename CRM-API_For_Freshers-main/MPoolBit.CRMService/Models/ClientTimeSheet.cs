using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientTimeSheet
    {
        public ClientTimeSheet()
        {
            ClientTimeSheetDesignation = new HashSet<ClientTimeSheetDesignation>();
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            ClientTimeSheetProject = new HashSet<ClientTimeSheetProject>();
        }

        public long Id { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? DocumentUploadId { get; set; }
        public string FileName { get; set; }
        public int? Month { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InvoiceNumber { get; set; }
        public long? PreparedById { get; set; }
        public long? CheckedById { get; set; }
        public long? ApprovedById { get; set; }
        public short? IsDeleted { get; set; }
        public short? IsFinal { get; set; }
        public long? FinancialPeriodId { get; set; }
        public long? ClientId { get; set; }
        public string Remarks { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public short? IsRawTimesheet { get; set; }

        public virtual User ApprovedBy { get; set; }
        public virtual User CheckedBy { get; set; }
        public virtual User Client { get; set; }
        public virtual Attachment DocumentUpload { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual User PreparedBy { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<ClientTimeSheetDesignation> ClientTimeSheetDesignation { get; set; }
        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual ICollection<ClientTimeSheetProject> ClientTimeSheetProject { get; set; }
    }
}
