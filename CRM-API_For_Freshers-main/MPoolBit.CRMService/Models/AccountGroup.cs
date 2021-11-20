using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountGroup
    {
        public AccountGroup()
        {
            Account = new HashSet<Account>();
            AccountGroupCode = new HashSet<AccountGroupCode>();
            AccountSettingsEmployeeLoanAccountGroup = new HashSet<AccountSettings>();
            AccountSettingsEmployeeSalaryAccountGroup = new HashSet<AccountSettings>();
            AccountSettingsSundryCreditorAccountGroup = new HashSet<AccountSettings>();
            AccountSettingsSundryDebtorAccountGroup = new HashSet<AccountSettings>();
            InverseParentLevelNavigation = new HashSet<AccountGroup>();
        }

        public long Id { get; set; }
        public string LevelName { get; set; }
        public string CodeNo { get; set; }
        public long? ParentLevel { get; set; }
        public short? IsDeleted { get; set; }
        public int? LevelNo { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual AccountGroup ParentLevelNavigation { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<AccountGroupCode> AccountGroupCode { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsEmployeeLoanAccountGroup { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsEmployeeSalaryAccountGroup { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSundryCreditorAccountGroup { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSundryDebtorAccountGroup { get; set; }
        public virtual ICollection<AccountGroup> InverseParentLevelNavigation { get; set; }
    }
}
