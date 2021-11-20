using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountDocumentCategory
    {
        public AccountDocumentCategory()
        {
            AccountDocument = new HashSet<AccountDocument>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AccountDocument> AccountDocument { get; set; }
    }
}
