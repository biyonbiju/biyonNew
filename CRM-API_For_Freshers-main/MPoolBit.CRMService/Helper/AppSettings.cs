using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Helper
{
    public class AppSettings
    {
        public string FilePath { get; set; }
        public string WorldstarSMSAPI { get; set; }
        public string WorldstarSMSUserName { get; set; }
        public string WorldstarSMSUserPassword { get; set; }
        public string WorldstarSMSSenderName { get; set; } 
        public string WorldstarDXBSMSAPI { get; set; }
        public string WorldstarDXBSMSUserName { get; set; }
        public string WorldstarDXBSMSUserPassword { get; set; }
        public string WorldstarDXBSMSSenderName { get; set; }
        public string WorldstarSharjaEmailUserName { get; set; }
        public string WorldstarSharjaEmailPassword { get; set; }
        public string WorldstarDXBEmailUserName { get; set; }
        public string WorldstarDXBEmailPassword { get; set; }
        public string EmailServerName { get; set; }
        public string WorldstarAUHEmailPassword { get;  set; }
        public string WorldstarAUHEmailUserName { get;  set; }
        public string TestPassword { get;  set; }
        public string TestUserName { get;  set; }
    }
}
