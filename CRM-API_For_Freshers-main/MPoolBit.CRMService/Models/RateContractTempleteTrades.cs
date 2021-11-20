using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class RateContractTempleteTrades
    {
        public long Id { get; set; }
        public long? RateContractTempleteId { get; set; }
        public long? RatetypeId { get; set; }
        public long? DesignationId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? AcctraCost { get; set; }
        public DateTime? Date { get; set; }
        public short? IsDeleted { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? NotRate { get; set; }
        public long? OccuranceId { get; set; }
        public decimal? TraCost { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual OccuranceType Occurance { get; set; }
        public virtual RateContractTemplete RateContractTemplete { get; set; }
        public virtual RateType Ratetype { get; set; }
    }
}
