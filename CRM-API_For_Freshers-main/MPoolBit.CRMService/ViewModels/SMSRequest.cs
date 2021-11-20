using MPoolBit.CRMService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class SMSRequest
    {
        public string? Authorization { get; set; }
        public List<string> MobileNumbers { get; set; }
        public List<MessageDetails> MessageDetails { get; set; }
        public string Message { get; set; }
        public string SenderName { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public bool RemoveDuplicates { get; set; }
        public string? ReferenceName { get; set; }
        public bool? ReportRequired { get; set; }
        public string? CallbackQueryString { get; set; }
        public bool? ReturnIndividualResponse { get; set; }
        public bool? AsynchronousSubmission { get; set; }
        public bool? BrightLinks { get; set; }
        public string? BrightLinksBaseURL { get; set; }
        public string? BrightLinksFinalURL { get; set; }
    }
}
