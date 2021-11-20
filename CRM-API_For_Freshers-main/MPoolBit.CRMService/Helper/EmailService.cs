
using MailKit.Security;
using Microsoft.Extensions.Logging;
using MimeKit;
using MPoolBit.CRMService.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;

namespace MPoolBit.CRMService.Helper
{
    public class EmailService
    {

        public string SendSingleUserAccountEmail(CrmleadReference crmleadReference, string subject, string envPath, string userEmailId, string password,long BranchId)
        {
            string result = "Success";
            try
            {
                var client = new SmtpClient("smtp.office365.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(userEmailId, password, "worldstarholding.com")
                };


                MailMessage mail = new MailMessage { From = new MailAddress(userEmailId, "World Star CRM") };
                mail.To.Add(crmleadReference.Email);
                mail.Body = GetTemplateMailBodyContent(crmleadReference, envPath, BranchId);
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                client.Send(mail);

                client.Dispose();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string OfficeSMTPMail(CrmleadReference crmleadReference, string subject, string envPath, string userEmailId, string password, string emailServer,long BranchId)
        {
            string result = "Success";
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("World Star CRM", userEmailId));
                message.To.Add(new MailboxAddress(crmleadReference.Name, crmleadReference.Email));
                message.Subject = subject;
                string targetDirectory = "";
                var multipart = new Multipart("mixed");
                if (BranchId == 1)
                {
                    targetDirectory = envPath + "\\Template\\wshnotice1.pdf";
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        targetDirectory = targetDirectory.Replace("\\", "/");
                    }
                    var textPart = new TextPart("html")
                    {
                        Text = GetTemplateMailBodyContent(crmleadReference, envPath, BranchId)
                    };
                    multipart.Add(textPart);
                    var attachmentPart = new MimePart(MediaTypeNames.Application.Pdf)
                    {
                        Content = new MimeContent(File.OpenRead(targetDirectory)),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(targetDirectory)
                    };
                    multipart.Add(attachmentPart);

                    message.Body = multipart;
                }
                else
                {
                    message.Body = new TextPart("html")
                    {
                        Text = GetTemplateMailBodyContent(crmleadReference, envPath, BranchId)
                    };
                }
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(emailServer, 587, SecureSocketOptions.StartTls);
                    client.Authenticate(userEmailId, password);
                    client.Send(message);
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string SendMultipleUserAccountEmail(CrmleadReference[] crmleadReference, string subject, long BranchId, string envPath)
        {
            string result = "Success";
            try
            {
                var client = new SmtpClient("smtp.office365.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };

                string fromEmail = BranchId == 1 ? "sales@manpowersupply.ae" : (BranchId == 2 ? "sales@marmoommanpower.com" : "info@worldstarmanpower.ae");

                foreach (CrmleadReference reference in crmleadReference)
                {
                    MailMessage mail = new MailMessage { From = new MailAddress(fromEmail, "Stimes") };
                    mail.To.Add(reference.Email);
                    mail.Body = GetTemplateMailBodyContent(reference, envPath, BranchId);
                    mail.IsBodyHtml = true;
                    mail.Subject = subject;
                    client.Send(mail);
                }

                client.Dispose();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public string SendSpecialDayGreetings(SpecialDayGreetings specialDayGreetings, string envPath,string fromEmail, string password, string emailServer)
        {
            string result = "Success";
            try
            {
                var multipart = new Multipart("mixed");
				var textPart = new TextPart("html")
								{
										Text = specialDayGreetings.Content
								};
                multipart.Add(textPart);
				var message = new MimeMessage();
                message.Subject = specialDayGreetings.Subject;
				message.From.Add(new MailboxAddress("World Star CRM", fromEmail));
				
				if(specialDayGreetings.AttachmentId != null){
					var targetDirectory = specialDayGreetings.AttachmentPath;
					if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        targetDirectory = targetDirectory.Replace("\\", "/");
                    }
					var type = "image/png";
					var attachmentPart = new MimePart(type)
					{
						Content = new MimeContent(File.OpenRead(targetDirectory)),
						ContentTransferEncoding = ContentEncoding.Base64,
						FileName = Path.GetFileName(targetDirectory)
					};
					multipart.Add(attachmentPart);
				}
                message.Body = multipart;

				using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(emailServer, 587, SecureSocketOptions.StartTls);
                    client.Authenticate(fromEmail, password);
                    foreach (SpecialDayGreetingsCustomer customer in specialDayGreetings.CustomerEmails)
					{
						MimeMessage messageToSent = new MimeMessage();
						messageToSent.From.Add(new MailboxAddress("World Star CRM", fromEmail));
						messageToSent.Subject = message.Subject;
						messageToSent.Body = message.Body;
						messageToSent.To.Add(new MailboxAddress(customer.Name, customer.Email));
						client.Send(messageToSent);
					}
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
            catch (Exception ex)
            {
				throw (ex);
			}
            return result;
        }
        private string GetTemplateMailBodyContent(CrmleadReference reference, string envPath, long BranchId)
        {
            var builder = new StringBuilder();
            string targetDirectory = "";
            if (BranchId == 1)
            {
                targetDirectory = envPath + "\\Template\\SharjaEmail.html";

            }
            else if (BranchId == 2)
            {
                targetDirectory = envPath + "\\Template\\DubaiEmail.html";

            }
            else if (BranchId == 3)
            {
                targetDirectory = envPath + "\\Template\\AbuDhabiEmail.html";
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                targetDirectory = targetDirectory.Replace("\\", "/");
            }

            using (var reader = System.IO.File.OpenText(targetDirectory))
            {
                builder.Append(reader.ReadToEnd());
            }

            builder.Replace("{{0}}", reference.Name);
            return builder.ToString();
        }


        //private string GetTemplateMailBodyContent(CrmleadReference reference, string envPath)
        //{
        //    var builder = new StringBuilder();

        //    string targetDirectory = envPath + "\\Template\\user_credentiall.html";

        //    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        //    {
        //        targetDirectory = targetDirectory.Replace("\\", "/");
        //    }

        //    using (var reader = System.IO.File.OpenText(targetDirectory))
        //    {
        //        builder.Append(reader.ReadToEnd());
        //    }

        //    builder.Replace("{{0}}", reference.Name);
        //    return builder.ToString();
        //}
        public string SendQuotationMail(QuotationMail quotationMail, string envPath, string fromEmail, string password, string emailServer)
        {
            string result = "Success";
            try
            {
                var multipart = new Multipart("mixed");
                //var textPart = new TextPart("html")
                //{
                //    Text = quotationMail.Content
                //};
              //  multipart.Add(textPart);
                var message = new MimeMessage();
                message.Subject = quotationMail.Subject;
                message.From.Add(new MailboxAddress("World Star CRM", fromEmail));

                if (quotationMail.AttachmentId != null)
                {
                    var targetDirectory = quotationMail.AttachmentPath;
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        targetDirectory = targetDirectory.Replace("\\", "/");
                    }
                    var type = "image/png";
                    var attachmentPart = new MimePart(type)
                    {
                        Content = new MimeContent(File.OpenRead(targetDirectory)),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(targetDirectory)
                    };
                    multipart.Add(attachmentPart);
                }
                message.Body = multipart;

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(emailServer, 587, SecureSocketOptions.StartTls);
                    client.Authenticate(fromEmail, password);
                    foreach (QuotationMailContacts customer in quotationMail.QuotationMailContacts)
                    {
                        MimeMessage messageToSent = new MimeMessage();
                        messageToSent.From.Add(new MailboxAddress("World Star CRM", fromEmail));
                        messageToSent.Subject = message.Subject;
                        messageToSent.Body = message.Body;
                        messageToSent.To.Add(new MailboxAddress("", customer.ToMail));
                        foreach(CcMail ccMail in customer.CcMail)
                        {
                            messageToSent.Cc.Add(new MailboxAddress("",ccMail.EmailId));

                        }
                        client.Send(messageToSent);
                    }
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return result;
        }

        public string SendEmail(CrmleadReference[] crmleadReference, string subject, long BranchId, string envPath)
        {
            string result = "Success";
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("info.asasasas@gmail.com", "NxtBit@12345")
                };

                foreach (CrmleadReference reference in crmleadReference)
                {
                    MailMessage mail = new MailMessage { From = new MailAddress("stimes@advqb.com", "Stimes") };
                    //mail.To.Add(reference.Email);
                    mail.To.Add("sarath.ps@sdasdasdas.com");
                    mail.Body = GetTemplateMailBodyContent(reference, envPath, BranchId);
                    mail.IsBodyHtml = true;
                    mail.Subject = subject;
                    client.Send(mail);
                }

                client.Dispose();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;

        }

        public string SendSingleEmail(CrmleadReference crmleadReference, string subject, long BranchId, string envPath)
        {
            string result = "Success";
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("info.assaasd@gmail.com", "NxtBit@12345")
                };

                MailMessage mail = new MailMessage { From = new MailAddress("stimes@advqb.com", "Stimes") };
                mail.To.Add(crmleadReference.Email);
                //mail.To.Add("sarath.ps@nxtbittechnologies.com");
                mail.Body = GetTemplateMailBodyContent(crmleadReference, envPath, BranchId);
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                client.Send(mail);

                client.Dispose();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;

        }

        //public static string SendEmail(string toAddress, string subject, string body)
        //{
        //    //try
        //    //{
        //    //    SmtpClient client1 = new SmtpClient("smtpout.secureserver.net", 25);//("smtp.gmail.com");
        //    //    client1.EnableSsl = true;
        //    //    client1.UseDefaultCredentials = false;
        //    //    client1.Credentials = new System.Net.NetworkCredential("saadullatk.stimes@gmail.com", "ilakarikal");
        //    //    client1.Port = 587;
        //    //    client1.Send("saadullatk.stimes@gmail.com", toAddress, subject, body);
        //    //}
        //    //catch (Exception ex) { }


        //    // MailMessage mailMessage = new MailMessage();
        //    // mailMessage.From = new MailAddress("saadullatk@mitasset.com");
        //    // mailMessage.To.Add(toAddress);
        //    //  mailMessage.Body = body;
        //    //  mailMessage.Subject = subject;
        //    //  mailMessage.IsBodyHtml = true;
        //    //  client.Send(mailMessage);
        //    //    try { 
        //    //    SmtpClient client = new SmtpClient("relay-hosting.secureserver.net", 25);
        //    //    MailMessage message = new MailMessage();
        //    //    message.From = new MailAddress("support@pctalents.com");

        //    //    message.To.Add(new MailAddress(toAddress));

        //    //    message.Subject = subject;
        //    //    message.Body = body;


        //    //    client.Send(message);
        //    //}
        //    //    catch (Exception ex) { }

        //    //    // _logger.LogError("Custom-sendmail function");

        //    //gmail working code -- on less secure app
        //    string result = "";
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        mail.To.Add(toAddress);
        //        mail.From = new MailAddress("saadullatk.stimes@gmail.com");//("pctalents2020@gmail.com");
        //        mail.Subject = subject;
        //        mail.Body = body;
        //        mail.IsBodyHtml = true;

        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Credentials = new System.Net.NetworkCredential("saadullatk.stimes@gmail.com", "ilakarikal");
        //        //("pctalents2020@gmail.com", "Pctalents@2019");
        //        smtp.EnableSsl = true;
        //        smtp.Send(mail);
        //    }
        //    catch (Exception ex)
        //    {
        //        result = ex.Message;
        //    }
        //    return result;
        //    // _logger.LogError("Custom-sendmail send");

        //}
    }
}
