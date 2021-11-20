using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            AccountNote = new HashSet<AccountNote>();
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            AccountUserInvoice = new HashSet<AccountUserInvoice>();
            GradeType = new HashSet<GradeType>();
            RateContractTemplete = new HashSet<RateContractTemplete>();
            User = new HashSet<User>();
            UserCategory = new HashSet<UserCategory>();
            UserTransfer = new HashSet<UserTransfer>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AccountNote> AccountNote { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoice { get; set; }
        public virtual ICollection<GradeType> GradeType { get; set; }
        public virtual ICollection<RateContractTemplete> RateContractTemplete { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserCategory> UserCategory { get; set; }
        public virtual ICollection<UserTransfer> UserTransfer { get; set; }
    }
}
