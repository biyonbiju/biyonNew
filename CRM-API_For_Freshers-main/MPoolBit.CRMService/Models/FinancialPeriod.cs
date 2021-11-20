using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class FinancialPeriod
    {
        public FinancialPeriod()
        {
            AccountInvoice = new HashSet<AccountInvoice>();
            AccountJournal = new HashSet<AccountJournal>();
            AccountJournalBook = new HashSet<AccountJournalBook>();
            AccountNote = new HashSet<AccountNote>();
            AccountOpeningBalance = new HashSet<AccountOpeningBalance>();
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            AccountSettings = new HashSet<AccountSettings>();
            AccountUserInvoice = new HashSet<AccountUserInvoice>();
            AttendanceRegister = new HashSet<AttendanceRegister>();
            ClientTimeSheet = new HashSet<ClientTimeSheet>();
            DemandRequest = new HashSet<DemandRequest>();
            LabourTimeCardHeader = new HashSet<LabourTimeCardHeader>();
            NocDetails = new HashSet<NocDetails>();
            Organisation = new HashSet<Organisation>();
            StaffSalaryHeader = new HashSet<StaffSalaryHeader>();
            SupplierTimeCardHeader = new HashSet<SupplierTimeCardHeader>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public short? IsCurrentPeriod { get; set; }

        public virtual ICollection<AccountInvoice> AccountInvoice { get; set; }
        public virtual ICollection<AccountJournal> AccountJournal { get; set; }
        public virtual ICollection<AccountJournalBook> AccountJournalBook { get; set; }
        public virtual ICollection<AccountNote> AccountNote { get; set; }
        public virtual ICollection<AccountOpeningBalance> AccountOpeningBalance { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<AccountSettings> AccountSettings { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoice { get; set; }
        public virtual ICollection<AttendanceRegister> AttendanceRegister { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheet { get; set; }
        public virtual ICollection<DemandRequest> DemandRequest { get; set; }
        public virtual ICollection<LabourTimeCardHeader> LabourTimeCardHeader { get; set; }
        public virtual ICollection<NocDetails> NocDetails { get; set; }
        public virtual ICollection<Organisation> Organisation { get; set; }
        public virtual ICollection<StaffSalaryHeader> StaffSalaryHeader { get; set; }
        public virtual ICollection<SupplierTimeCardHeader> SupplierTimeCardHeader { get; set; }
    }
}
