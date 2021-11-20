using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserRate
    {
        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public long? UserId { get; set; }
        public long? RateTypeId { get; set; }
        public string Details { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Acctracost { get; set; }
        public DateTime? Date { get; set; }
        public long? DesignationId { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? NotRate { get; set; }
        public long? OccuranceId { get; set; }
        public decimal? TraCost { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual OccuranceType Occurance { get; set; }
        public virtual RateType RateType { get; set; }
        public virtual User User { get; set; }
    }
}
