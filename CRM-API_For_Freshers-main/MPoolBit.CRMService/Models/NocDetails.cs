using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocDetails
    {
        public NocDetails()
        {
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public DateTime? DocDate { get; set; }
        public string DocNo { get; set; }
        public long? ClientId { get; set; }
        public long? ProjectId { get; set; }
        public string Remarks { get; set; }
        public long? RegardsId { get; set; }
        public long? AssistanceId { get; set; }
        public DateTime? MobilizeDate { get; set; }
        public string MoblieNo { get; set; }
        public long? ReportTypeId { get; set; }
        public short? IsReplacement { get; set; }
        public short? PassportDownload { get; set; }
        public short? VisaDownload { get; set; }
        public short? EmiratesIdDownload { get; set; }
        public short? TradeLicenceDownload { get; set; }
        public short? WorkCompensationDownload { get; set; }
        public short? InsuranceDownload { get; set; }
        public short? CertificateDownload { get; set; }
        public short? GatePassDownload { get; set; }
        public short? PhotoDownload { get; set; }
        public short? SupplierUnderTakingDownload { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public long? DemandRequestId { get; set; }
        public long? NocStatusId { get; set; }

        public virtual User Assistance { get; set; }
        public virtual User Client { get; set; }
        public virtual DemandRequest DemandRequest { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual NocStatus NocStatus { get; set; }
        public virtual Project Project { get; set; }
        public virtual User Regards { get; set; }
        public virtual NocReportType ReportType { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
    }
}
