using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocEmployeeDetails
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? SafetyStatusId { get; set; }
        public long? TradeChangeId { get; set; }
        public long? ReasonId { get; set; }
        public short? TrainingRequest { get; set; }
        public string Remarks { get; set; }
        public short? IsApproved { get; set; }
        public DateTime? MobilizeDate { get; set; }
        public short? IsMobilized { get; set; }
        public string WorkComment { get; set; }
        public string Complaint { get; set; }
        public DateTime? DeMobilizeDate { get; set; }
        public long? DeMobilizeStatusId { get; set; }
        public long? AccomadationStatusId { get; set; }
        public long? TransportationStatusId { get; set; }
        public long? DeMobilizeRequestId { get; set; }
        public long? NocDetailsId { get; set; }
        public short? IsOperationApproved { get; set; }
        public short? IsSalesApproved { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public short? IsDeleted { get; set; }
        public short? IsDemobilized { get; set; }
        public long? DeMobilizeReasonId { get; set; }
        public long? ProjectLocationId { get; set; }
        public long? RateTypeId { get; set; }
        public string ClientProjectId { get; set; }
        public short? IsCancelled { get; set; }

        public virtual NocAccomadationStatus AccomadationStatus { get; set; }
        public virtual DeMobilizeReason DeMobilizeReason { get; set; }
        public virtual User DeMobilizeRequest { get; set; }
        public virtual NocDeMobilizeStatus DeMobilizeStatus { get; set; }
        public virtual User Employee { get; set; }
        public virtual NocDetails NocDetails { get; set; }
        public virtual ProjectLocation ProjectLocation { get; set; }
        public virtual ProjectRate RateType { get; set; }
        public virtual NocTradeReason Reason { get; set; }
        public virtual NocSafetyStatus SafetyStatus { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual Designation TradeChange { get; set; }
        public virtual NocAccomadationStatus TransportationStatus { get; set; }
    }
}
