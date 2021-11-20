using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectRate
    {
        public ProjectRate()
        {
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public long? ProjectId { get; set; }
        public long? RateTypeId { get; set; }
        public long? DetailsId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Acctracost { get; set; }
        public DateTime? Date { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? NotRate { get; set; }
        public long? OccuranceId { get; set; }

        public virtual Designation Details { get; set; }
        public virtual OccuranceType Occurance { get; set; }
        public virtual Project Project { get; set; }
        public virtual RateType RateType { get; set; }
        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
    }
}
