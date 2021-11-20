using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientTimeSheetEmployee
    {
        public long Id { get; set; }
        public long? ClientTimeSheetId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? Day { get; set; }
        public decimal? NotHrs { get; set; }
        public decimal? HotHrs { get; set; }
        public decimal? IncHrs { get; set; }
        public decimal? NormalRate { get; set; }
        public decimal? NotRate { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? IncRate { get; set; }
        public decimal? NormalAmt { get; set; }
        public decimal? NotAmt { get; set; }
        public decimal? HotAmt { get; set; }
        public decimal? IncAmt { get; set; }
        public decimal? DedHrs { get; set; }
        public decimal? DedRate { get; set; }
        public decimal? DedAmt { get; set; }
        public long? ProjectId { get; set; }
        public long? DesignationId { get; set; }
        public short? IsAbsent { get; set; }
        public short? IsHoliday { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public decimal? NormalHrs { get; set; }
        public short? IsTimeSheetFinal { get; set; }
        public short? IsInvoiceFinal { get; set; }
        public short? IsRawTimesheet { get; set; }
        public short? IsDeleted { get; set; }
        public string ClientEmployeeId { get; set; }
        public long? ProjectRateId { get; set; }
        public long? OrderNo { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual ClientTimeSheet ClientTimeSheet { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual User Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectRate ProjectRate { get; set; }
    }
}
