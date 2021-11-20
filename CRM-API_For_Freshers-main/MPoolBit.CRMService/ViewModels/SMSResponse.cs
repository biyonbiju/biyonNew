using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class IndividualResponse
    {
        public int countryId { get; set; }
        public string creditsUsed { get; set; }
        public string details { get; set; }
        public int messageLength { get; set; }
        public string mobileNo { get; set; }
        public int msgId { get; set; }
        public string status { get; set; }
        public int? errorCode { get; set; }
    }

    public class Data
    {
        public int bulkId { get; set; }
        public int totalValidNumbers { get; set; }
        public List<IndividualResponse> individualResponse { get; set; }
    }

    public class SMSResponse
    {
        public string status { get; set; }
        public string errorDescription { get; set; }
        public Data data { get; set; }
    }


}
