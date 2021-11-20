using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AttendanceRegister
    {
        public AttendanceRegister()
        {
            AttendanceRegisterDetails = new HashSet<AttendanceRegisterDetails>();
        }

        public long Id { get; set; }
        public DateTime? DocDate { get; set; }
        public string ReferenceNo { get; set; }
        public short? IsHoliday { get; set; }
        public long? ProjectId { get; set; }
        public string Remark { get; set; }
        public short? IsCompleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? Day { get; set; }
        public short? IsCamp { get; set; }
        public long? CampId { get; set; }
        public long? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Camp Camp { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual Project Project { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
    }
}
