using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectHolidayDetails
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public short? IsDeleted { get; set; }
        public long? HolidayTypeId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? Days { get; set; }
        public long? ProjectId { get; set; }

        public virtual HolidayType HolidayType { get; set; }
        public virtual Project Project { get; set; }
    }
}
