using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class DemandRequest
    {
        public DemandRequest()
        {
            DemandRequestAllocation = new HashSet<DemandRequestAllocation>();
            DemandRequestTrades = new HashSet<DemandRequestTrades>();
            NocDetails = new HashSet<NocDetails>();
        }

        public long Id { get; set; }
        public string RequestNo { get; set; }
        public long? RequestTypeId { get; set; }
        public long? ClientId { get; set; }
        public long? ProjectId { get; set; }
        public int? DemandQuantity { get; set; }
        public string Remarks { get; set; }
        public DateTime? RequestDate { get; set; }
        public decimal? Rate { get; set; }
        public long? RequestStatusId { get; set; }
        public long? RequestReasonId { get; set; }
        public long? RequestActionId { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public short? IsOperationApproved { get; set; }
        public short? IsAllocated { get; set; }
        public long? FatId { get; set; }
        public long? TransportationStatusId { get; set; }
        public long? RequestedById { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual User Client { get; set; }
        public virtual NocAccomadationStatus Fat { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual Project Project { get; set; }
        public virtual DemandRequestAction RequestAction { get; set; }
        public virtual DemandRequestReason RequestReason { get; set; }
        public virtual DemandRequestStatus RequestStatus { get; set; }
        public virtual DemandRequestType RequestType { get; set; }
        public virtual User RequestedBy { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual NocAccomadationStatus TransportationStatus { get; set; }
        public virtual ICollection<DemandRequestAllocation> DemandRequestAllocation { get; set; }
        public virtual ICollection<DemandRequestTrades> DemandRequestTrades { get; set; }
        public virtual ICollection<NocDetails> NocDetails { get; set; }
    }
}
