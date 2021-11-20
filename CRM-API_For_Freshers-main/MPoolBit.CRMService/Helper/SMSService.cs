using System;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
using System.Web;

namespace MPoolBit.CRMService.Helper
{
    public class SMSService
    {
        public static string SendSMS(string phone, string message)
        {
            String encodedMessage = HttpUtility.UrlEncode(message);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                {"apikey" , "vmYDMwngjV0-I9ldy5HbWh9x4WeNizTGxNptTf6GEM"},
                {"numbers" , phone},
                {"message" , encodedMessage},
                {"sender" , "PCTLNT"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);


                return result;
            }
        }
    }
}
