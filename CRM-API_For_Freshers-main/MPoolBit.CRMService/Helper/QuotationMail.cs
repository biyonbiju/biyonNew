using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Helper
{
    public class QuotationMail
    {
        public long BranchId { get; set; }
        public long? AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public List<QuotationMailContacts> QuotationMailContacts { get; set; }
    }

    public class QuotationMailContacts
    {
        public string ToMail { get; set; }
        public List<CcMail> CcMail { get; set; }
    }
    public class CcMail
    {
        public string EmailId { get; set; }
    }
}
