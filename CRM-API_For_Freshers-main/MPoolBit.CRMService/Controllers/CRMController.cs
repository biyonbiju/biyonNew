using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MPoolBit.CRMService.Helper;
using MPoolBit.CRMService.Models;
using LinqKit;
using MPoolBit.CRMService.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;

namespace MPoolBit.CRMService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRMController : ControllerBase
    {
        private readonly worldstar_newContext DBContext;
        private readonly int _crmCustomerRoleId = 7;
        private readonly int _crmLeadNo = 8;
        private readonly int _crmTaskNo = 10;
        private readonly int _crmOportunity = 9;
        private readonly int _tradeLicenceDoc = 54;
        private readonly int _AgreementDoc = 50;
        private readonly int _LPODoc = 52;
        private const int _labourRoleId = 5;
        private const int _normalUserRoleRuleId = 5;
        private const int _supplierLabourRoleId = 6;
        private const int _staffRoleId = 2;
        private readonly IWebHostEnvironment _environment;

        public readonly AppSettings Settings;
        public CRMController(worldstar_newContext context, IOptions<AppSettings> appSettings, IWebHostEnvironment env)
        {
            DBContext = context;
            Settings = appSettings.Value;
            _environment = env;
            //DBContext.Database.SetCommandTimeout(120);
        }
        [HttpGet("GetCRMCompanyType/{Id}")]
        public async Task<IActionResult> GetCRMCompanyType(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmcompanyType
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCRMCompanyType")]
        public async Task<IActionResult> GetAllCRMCompanyType()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmcompanyType
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllLookUps")]
        public async Task<IActionResult> GetAllLookUps()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {

                var result = DBContext.CrmcompanyType.Where(x => x.IsDeleted != 1).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                            new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                MaxDepth = 1
                            });
                masterDataObject.CRMCompanyTypes = JArray.Parse(jsonResult);
                //var result = await (DBContext.CrmcompanyType
                //    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                //var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                //        new JsonSerializerSettings()
                //        {
                //            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                //        });
                //masterDataObject.CRMCompanyTypes = new JArray(jsonResult) as dynamic;
                // masterDataObject.CRMCompanyTypes.Add(JArray.Parse(jsonResult));

                var result1 = await (DBContext.CrmleadComments
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult1 = Newtonsoft.Json.JsonConvert.SerializeObject(result1, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmleadComments = JArray.Parse(jsonResult1);
                //  masterDataObject.CrmleadComments.Add(JArray.Parse(jsonResult1));

                var result2 = await (DBContext.CrmleadSource
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult2 = Newtonsoft.Json.JsonConvert.SerializeObject(result2, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmleadSource = JArray.Parse(jsonResult2);
                // masterDataObject.CrmleadSource.Add(JArray.Parse(jsonResult2));


                var result3 = await (DBContext.CrmleadStatus
                   .Where(x => x.IsDeleted != 1 && x.CrmType == "Lead")).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult3 = Newtonsoft.Json.JsonConvert.SerializeObject(result3, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmleadStatus = JArray.Parse(jsonResult3);
                // masterDataObject.CrmleadStatus.Add(JArray.Parse(jsonResult3));

                var result4 = await (DBContext.Crmpriority
                   .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult4 = Newtonsoft.Json.JsonConvert.SerializeObject(result4, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Crmpriority = JArray.Parse(jsonResult4);
                //masterDataObject.Crmpriority.Add(JArray.Parse(jsonResult4));


                var result5 = await (DBContext.Crmpurpose
                   .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult5 = Newtonsoft.Json.JsonConvert.SerializeObject(result5, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Crmpurpose = JArray.Parse(jsonResult5);
                //masterDataObject.Crmpurpose.Add(JArray.Parse(jsonResult5));

                var result6 = await (DBContext.CrmtaskType
                   .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult6 = Newtonsoft.Json.JsonConvert.SerializeObject(result6, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmtaskType = JArray.Parse(jsonResult6);
                // masterDataObject.CrmtaskType.Add(JArray.Parse(jsonResult6));


                var result7 = await (DBContext.Emirate
                   .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult7 = Newtonsoft.Json.JsonConvert.SerializeObject(result7, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Emirates = JArray.Parse(jsonResult7);

                var result8 = await (DBContext.Designation
                  .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult8 = Newtonsoft.Json.JsonConvert.SerializeObject(result8, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Designations = JArray.Parse(jsonResult8);

                var result9 = await (DBContext.Location
  .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult9 = Newtonsoft.Json.JsonConvert.SerializeObject(result9, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.ProjectLocations = JArray.Parse(jsonResult9);

                var result10 = await (DBContext.CrmleadStatus
              .Where(x => x.IsDeleted != 1 && x.CrmType == "Opportunity")).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult10 = Newtonsoft.Json.JsonConvert.SerializeObject(result10, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmOpporunityStatus = JArray.Parse(jsonResult10);

                var result11 = await (DBContext.CrmleadStatus
             .Where(x => x.IsDeleted != 1 && x.CrmType == "Task")).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult11 = Newtonsoft.Json.JsonConvert.SerializeObject(result11, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.CrmTaskStatus = JArray.Parse(jsonResult11);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCRMCompanyType")]
        public async Task<IActionResult> InsertCRMCompanyType([FromBody] CrmcompanyType CRMCompanyType)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CRMCompanyTypeId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmcompanyType.Update(CRMCompanyType);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CRMCompanyTypeId.Value = newUser.Entity.Id;
                }
                else
                    CRMCompanyTypeId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CRMCompanyTypeId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        //[HttpPost("UpdateCRMCompanyType")]
        //public async Task<IActionResult> UpdateCRMCompanyType([FromBody] CrmcompanyType CRMCompanyType)
        //{
        //    var jsonObject = new JObject();
        //    JProperty error = new JProperty("ErrorMessage", "");
        //    JProperty sucess = new JProperty("SuccessMessage", "Sucess");
        //    try
        //    {
        //        DBContext.CrmcompanyType.Update(CRMCompanyType);
        //        DBContext.SaveChanges();
        //    }
        //    catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
        //    dynamic ItemObject = jsonObject;
        //    jsonObject.Add(error);
        //    jsonObject.Add(sucess);
        //    return Ok(ItemObject);
        //}
        //[HttpPost("DeleteCRMCompanyType")]
        //public async Task<IActionResult> DeleteCRMCompanyType([FromBody] CrmcompanyType CRMCompanyType)
        //{
        //    var jsonObject = new JObject();
        //    JProperty error = new JProperty("ErrorMessage", "");
        //    JProperty sucess = new JProperty("SuccessMessage", "Sucess");
        //    try
        //    {
        //        CRMCompanyType.IsDeleted = 1;
        //        DBContext.CrmcompanyType.Update(CRMCompanyType);
        //        DBContext.SaveChanges();
        //    }
        //    catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
        //    dynamic ItemObject = jsonObject;
        //    jsonObject.Add(error);
        //    jsonObject.Add(sucess);
        //    return Ok(ItemObject);
        //}

        #region CRMLead

        [HttpGet("GetCrmlead/{Id}")]
        public async Task<IActionResult> GetCrmlead(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmlead.Include(x => x.CrmleadDetails)
                   .Where(x => x.Id == Id && x.IsDeleted != 1))
                   .Select(x => new
                    {
                        Id = x.Id,
                        x.IsDeleted,
                        x.LeadNo,
                        x.BranchId,
                        x.ClientId,
                        x.Date,
                        x.CompanyName,
                        x.IsClient,
                        x.IsFatown,
                        x.Longitude,
                        x.Latitude,
                        x.Pbno,
                        x.PhotoId,
                        x.ModeOfCompletionId,
                        Photo = new
                        {
                            Id = x.Photo.Id,
                            x.Photo.FilePath
                        },
                        x.ProjectSitePhotoId,
                        ProjectSitePhoto = new
                        {
                            Id = x.ProjectSitePhoto.Id,
                            x.ProjectSitePhoto.FilePath
                        },
                        x.OfficePhotoId,
                        OfficePhoto = new
                        {
                            Id = x.OfficePhoto.Id,
                            x.OfficePhoto.FilePath
                        },
                        Client = new
                        {
                            Id = x.ClientId,
                            x.Client.BasicDetail.IncorporatedName,
                            x.Client.BasicDetailId,
                            x.Client.UserRoleId,
                            x.Client.UserDetailsId,
                            x.Client.UserRoleRuleId
                        },
                        x.ProjectName,
                        x.ContactPerson,
                        x.WorkCategoryId,
                        x.AssignedSalesExecutiveId,

                        AssignedSalesExecutive = new
                        {
                            Id = x.AssignedSalesExecutive.Id,
                            x.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                            x.AssignedSalesExecutive.BasicDetail.FirstName,
                            x.AssignedSalesExecutive.BasicDetail.MiddleName,
                            x.AssignedSalesExecutive.BasicDetail.Pobox,
                            x.AssignedSalesExecutive.BasicDetail.EmailId,
                            MobileNo = x.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                            x.AssignedSalesExecutive.BasicDetailId,
                            x.AssignedSalesExecutive.UserRoleId,
                            x.AssignedSalesExecutive.UserDetailsId,
                            x.AssignedSalesExecutive.UserRoleRuleId
                        },
                        x.ProjectLocationId,
                        ProjectLocation = new
                        {
                            Id = x.ProjectLocation.Id,
                            x.ProjectLocation.Name
                        },
                       x.LeadStatusCommentId,
                       LeadStatusComment = new
                       {
                           Id = x.LeadStatusComment.Id,
                           x.LeadStatusComment.Comment,
                           x.LeadStatusComment.IsDeleted
                       },
                       x.SourceId,
                        Source = new
                        {
                            Id = x.SourceId,
                            x.Source.Source
                        },
                        CrmleadReference = x.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                        {
                            Id = y.Id,
                            y.DefaultContact,
                            y.Name,
                            y.DesignationId,
                            Designation = new { Id = y.Designation.Id, y.Designation.Name },
                            y.ContactNo,
                            y.Email,
							y.CustomerReferenceId
                        }),
                        x.CompanyLocationId,
                        CompanyLocation = new
                        {
                            Id = x.CompanyLocation.Id,
                            x.CompanyLocation.Name
                        },
                        x.CompanyTypeId,
                        CompanyType = new
                        {
                            Id = x.CompanyType.Id,
                            x.CompanyType.Type,
                            x.CompanyType.IsDeleted
                        },
                        CrmleadDetails = x.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                        {
                            Id= y.Id,
                            FAT = new { Id = y.FAT.Id, y.FAT.Type },
                            y.FATId,
                            y.Trade,
                            y.TradeId,
                            y.Qty,
                            y.Rate,
                            y.TypeId,
                        }),
                        x.EmiratesId,
                        Emirates = new
                        {
                            Id = x.Emirates.Id,
                            x.Emirates.CountryId,
                            x.Emirates.ExtensionCode,
                            x.Emirates.Name,
                            x.Emirates.IsDeleted
                        },
                        x.IsActive,
                        x.LeadStatusId,
                        LeadStatus = new
                        {
                            Id = x.LeadStatus.Id,
                            x.LeadStatus.CrmType,
                            x.LeadStatus.Status,
                            x.LeadStatus.IsDeleted
                        },
                        x.SponsorShipCompanyId,
                        x.TelNo,
                        x.WebSite,
                        CrmleadDocuments = x.CrmleadDocuments.Where(x => x.IsDeleted != 1).Select(y => new
                        {
                            Id = y.Id,
                            y.IsDeleted,
                            y.AttachmentId,
                            y.Description,
                            y.ExpiryDate,
                            y.LeadId,
                           y.DocumentTypeId,
                            DocumentType = new
                            {
                                Id = y.DocumentType.Id,
                                y.DocumentType.Type,
                                y.DocumentType.IsDeleted
                            },
                            Attachment = new
                            {
                                Id = y.Attachment.Id,
                                y.Attachment.FilePath,
                                y.Attachment.Description
                            },
                        }),
						LeadComments= x.LeadComments.Where(y => y.IsDeleted != 1).Select(y => new {
							y.Id,
							y.LeadId,
							y.CommentId,
							y.IsDeleted,
							CommentLabel = y.Comment.Comment
						}),
                    }).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmlead/{BranchId}")]
        public async Task<IActionResult> GetAllCrmlead(long BranchId)
        {

            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                //var existingLeads=DBContext.Crmopportunity.Where(x => x.LeadId > 0).Distinct().ToList();
                var result = await (DBContext.Crmlead
                    .Where(x => x.IsDeleted != 1 && x.BranchId == BranchId)
                       .Select(x => new
                       {
                           Id = x.Id,
                           x.IsDeleted,
                           x.LeadNo,
                           x.BranchId,
                           x.ClientId,
                           x.Date,
                           x.CompanyName,
                           x.IsClient,
                           x.IsFatown,
                           x.Longitude,
                           x.Latitude,
                           x.Pbno,

                           x.PhotoId,
                           Photo = new
                           {
                               Id = x.Photo.Id,
                               x.Photo.FilePath
                           },
                           x.ProjectSitePhotoId,
                           ProjectSitePhoto = new
                           {
                               Id = x.ProjectSitePhoto.Id,
                               x.ProjectSitePhoto.FilePath
                           },
                           x.OfficePhotoId,
                           OfficePhoto = new
                           {
                               Id = x.OfficePhoto.Id,
                               x.OfficePhoto.FilePath
                           },
                           Client = new
                           {
                               Id = x.ClientId,
                               x.Client.BasicDetail.IncorporatedName,
                               x.Client.BasicDetailId,
                               x.Client.UserRoleId,
                               x.Client.UserDetailsId,
                               x.Client.UserRoleRuleId
                           },
                           x.ProjectName,
                           x.ContactPerson,
                           x.WorkCategoryId,
                           x.AssignedSalesExecutiveId,
                           AssignedSalesExecutive = new
                           {
                               Id = x.AssignedSalesExecutive.Id,
                               x.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                               x.AssignedSalesExecutive.BasicDetail.FirstName,
                               x.AssignedSalesExecutive.BasicDetail.MiddleName,
                               x.AssignedSalesExecutive.BasicDetail.Pobox,
                               x.AssignedSalesExecutive.BasicDetail.EmailId,
                               MobileNo = x.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                               x.AssignedSalesExecutive.BasicDetailId,
                               x.AssignedSalesExecutive.UserRoleId,
                               x.AssignedSalesExecutive.UserDetailsId,
                               x.AssignedSalesExecutive.UserRoleRuleId
                           },
                           x.ProjectLocationId,
                           ProjectLocation = new
                           {
                               Id = x.ProjectLocation.Id,
                               x.ProjectLocation.Name
                           },
                           x.SourceId,
                           Source = new
                           {
                               Id = x.SourceId,
                               x.Source.Source
                           },
                           CrmleadReference = x.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                           {
                               Id = y.Id,
                               y.DefaultContact,
                               y.Name,
                               y.DesignationId,
                               Designation = new { Id = y.Designation.Id, y.Designation.Name },
                               y.ContactNo,
                               y.Email
                           }),
                           x.CompanyLocationId,
                           CompanyLocation = new
                           {
                               Id = x.CompanyLocation.Id,
                               x.CompanyLocation.Name
                           },
                           x.CompanyTypeId,
                           CompanyType = new
                           {
                               Id = x.CompanyType.Id,
                               x.CompanyType.Type,
                               x.CompanyType.IsDeleted
                           },
                           CrmleadDetails = x.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                           {
                               Id = y.Id,
                               FAT = new { Id = y.FAT.Id, y.FAT.Type },
                               y.FATId,
                               y.Trade,
                               y.TradeId,
                               y.Qty,
                               y.Rate,
                               y.TypeId
                           }),
                           x.EmiratesId,
                           Emirates = new
                           {
                               Id = x.Emirates.Id,
                               x.Emirates.CountryId,
                               x.Emirates.ExtensionCode,
                               x.Emirates.Name,
                               x.Emirates.IsDeleted
                           },
                           x.IsActive,
                           x.LeadStatusId,
                           LeadStatus = new
                           {
                               Id = x.LeadStatus.Id,
                               x.LeadStatus.CrmType,
                               x.LeadStatus.Status,
                               x.LeadStatus.IsDeleted
                           },
                           x.LeadStatusCommentId,
                           LeadStatusComment = new
                           {
                               Id = x.LeadStatusComment.Id,
                               x.LeadStatusComment.Comment,
                               x.LeadStatusComment.IsDeleted
                           },
                           x.SponsorShipCompanyId,
                           x.TelNo,
                           x.WebSite,
                           CrmleadDocuments = x.CrmleadDocuments.Where(x => x.IsDeleted != 1).Select(y => new
                           {
                               Id = y.Id,
                               y.IsDeleted,
                               y.AttachmentId,
                               y.Description,
                               y.ExpiryDate,
                               y.LeadId,
                           y.DocumentTypeId,
                               DocumentType = new
                               {
                                   Id = y.DocumentType.Id,
                                   y.DocumentType.Type,
                                   y.DocumentType.IsDeleted
                               },
                               Attachment = new
                               {
                                   Id = y.Attachment.Id,
                                   y.Attachment.FilePath,
                                   y.Attachment.Description
                               }

                           }),

                       }) .OrderByDescending(x => x.Id).ToListAsync());
                //await (DBContext.CrmleadReference.Where(x => x.IsDeleted != 1).Include(x => x.Designation).ToListAsync());
                //if (result != null && result.Count > 0)
                //{
                //    result.ForEach(x =>
                //    {
                //        x.CrmleadDetails.ToList().ForEach(z => { if (z.Trade != null && z.Trade.CrmleadDetails != null) { z.Trade.CrmleadDetails = null; } });
                //        if (x.Designation != null) x.Designation.CrmleadDetails = null;
                //        x.CrmleadDetails.ToList().ForEach(y => { y.Lead = null; if (y.Trade != null && y.Trade.CrmleadDetails != null) { y.Trade.CrmleadDetails = null; } });
                //    });

                //}
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpGet("getAllLeadsByUser/{Id}")]
        public async Task<IActionResult> getAllLeadsByUser(long Id)
        {

            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                //var existingLeads=DBContext.Crmopportunity.Where(x => x.LeadId > 0).Distinct().ToList();
                var result = await (DBContext.Crmlead
                    .Where(x => x.IsDeleted != 1 && x.AssignedSalesExecutiveId == Id)
                   .Select(x => new
                   {
                       Id = x.Id,
                       x.IsDeleted,
                       x.LeadNo,
                       x.BranchId,
                       x.ClientId,
                       x.Date,
                       x.CompanyName,
                       x.IsClient,
                       x.IsFatown,
                       x.Longitude,
                       x.Latitude,
                       x.Pbno,

                       x.PhotoId,
                       Photo = new
                       {
                           Id = x.Photo.Id,
                           x.Photo.FilePath
                       },
                       x.ProjectSitePhotoId,
                       ProjectSitePhoto = new
                       {
                           Id = x.ProjectSitePhoto.Id,
                           x.ProjectSitePhoto.FilePath
                       },
                       x.OfficePhotoId,
                       OfficePhoto = new
                       {
                           Id = x.OfficePhoto.Id,
                           x.OfficePhoto.FilePath
                       },
                       Client = new
                       {
                           Id = x.ClientId,
                           x.Client.BasicDetail.IncorporatedName,
                           x.Client.BasicDetailId,
                           x.Client.UserRoleId,
                           x.Client.UserDetailsId,
                           x.Client.UserRoleRuleId
                       },
                       x.ProjectName,
                       x.ContactPerson,
                       x.WorkCategoryId,
                       x.AssignedSalesExecutiveId,
                       AssignedSalesExecutive = new
                       {
                           Id = x.AssignedSalesExecutive.Id,
                           x.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                           x.AssignedSalesExecutive.BasicDetail.FirstName,
                           x.AssignedSalesExecutive.BasicDetail.MiddleName,
                           x.AssignedSalesExecutive.BasicDetail.Pobox,
                           x.AssignedSalesExecutive.BasicDetail.EmailId,
                           MobileNo = x.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                           x.AssignedSalesExecutive.BasicDetailId,
                           x.AssignedSalesExecutive.UserRoleId,
                           x.AssignedSalesExecutive.UserDetailsId,
                           x.AssignedSalesExecutive.UserRoleRuleId
                       },
                       x.ProjectLocationId,
                       ProjectLocation = new
                       {
                           Id = x.ProjectLocation.Id,
                           x.ProjectLocation.Name
                       },
                       x.SourceId,
                       Source = new
                       {
                           Id = x.SourceId,
                           x.Source.Source
                       },
                       CrmleadReference = x.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                       {
                               Id = y.Id,
                           y.DefaultContact,
                           y.Name,
                           y.DesignationId,
                           Designation = new { Id = y.Designation.Id, y.Designation.Name },
                           y.ContactNo,
                           y.Email
                       }),
                       x.CompanyLocationId,
                       CompanyLocation = new
                       {
                           Id = x.CompanyLocation.Id,
                           x.CompanyLocation.Name
                       },
                       x.CompanyTypeId,
                       CompanyType = new
                       {
                           Id = x.CompanyType.Id,
                           x.CompanyType.Type,
                           x.CompanyType.IsDeleted
                       },
                       CrmleadDetails = x.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                       {
                           Id = y.Id,
                           FAT = new { Id = y.FAT.Id, y.FAT.Type },
                           y.FATId,
                           y.Trade,
                           y.TradeId,
                           y.Qty,
                           y.Rate,
                           y.TypeId
                       }),
                       x.EmiratesId,
                       Emirates = new
                       {
                           Id = x.Emirates.Id,
                           x.Emirates.CountryId,
                           x.Emirates.ExtensionCode,
                           x.Emirates.Name,
                           x.Emirates.IsDeleted
                       },
                       x.IsActive,
                       x.LeadStatusId,
                       LeadStatus = new
                       {
                           Id = x.LeadStatus.Id,
                           x.LeadStatus.CrmType,
                           x.LeadStatus.Status,
                           x.LeadStatus.IsDeleted
                       },
                       x.LeadStatusCommentId,
                       LeadStatusComment = new
                       {
                           Id = x.LeadStatusComment.Id,
                           x.LeadStatusComment.Comment,
                           x.LeadStatusComment.IsDeleted
                       },
                       x.SponsorShipCompanyId,
                       x.TelNo,
                       x.WebSite,
                       CrmleadDocuments = x.CrmleadDocuments.Where(x => x.IsDeleted != 1).Select(y => new
                       {
                           Id = y.Id,
                           y.IsDeleted,
                           y.AttachmentId,
                           y.Description,
                           y.ExpiryDate,
                           y.LeadId,
                           y.DocumentTypeId,
                           DocumentType = new
                           {
                               Id = y.DocumentType.Id,
                               y.DocumentType.Type,
                               y.DocumentType.IsDeleted
                           },
                           Attachment = new
                           {
                               Id = y.Attachment.Id,
                               y.Attachment.FilePath,
                               y.Attachment.Description
                           }

                       }),

                   }).OrderByDescending(x => x.Id).ToListAsync());
                //if (result != null && result.Count > 0)
                //{
                //    result.ForEach(x =>
                //    {
                //        x.CrmleadDetails.ToList().ForEach(z => { if (z.Trade != null && z.Trade.CrmleadDetails != null) { z.Trade.CrmleadDetails = null; } });
                //        if (x.Designation != null) x.Designation.CrmleadDetails = null;
                //        x.CrmleadDetails.ToList().ForEach(y => { y.Lead = null; if (y.Trade != null && y.Trade.CrmleadDetails != null) { y.Trade.CrmleadDetails = null; } });
                //    });

                //}
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("GetAllAllCrmleadByPage1")]
        public async Task<IActionResult> GetAllAllCrmleadByPage1([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                var predicate = PredicateBuilder.New<Crmlead>(x => x.IsDeleted != 1);
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.CompanyName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Source.Source.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.LeadNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ContactPerson.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ProjectName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ContactNumber.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.AssignedSalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower())
                     || x.Client.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower())
                    );
                }
                if ((page.Filters != null && page.Filters.Count > 0))
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "No":
                                predicate = predicate.And(x => x.LeadNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "CompanyName":
                                predicate = predicate.And(x => x.CompanyName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Source.Source":
                                predicate = predicate.And(x => x.Source.Source.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ContactPerson":
                                predicate = predicate.And(x => x.ContactPerson.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ContactNumber":
                                predicate = predicate.And(x => x.ContactNumber.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ProjectName":
                                predicate = predicate.And(x => x.ProjectName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "AssignedSalesExecutive.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.AssignedSalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Client.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.Client.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "LeadStatusId":
                                predicate = predicate.And(x => x.LeadStatusId == Convert.ToInt64(val.Value));
                                break;
                        }
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                var result = await (DBContext.Crmlead.
                    Where(x => x.BranchId == page.BranchId && (x.AssignedSalesExecutiveId == page.UserId || page.UserId == 0))
                    .Include(x => x.CrmleadDetails)//.Include(x => x.CrmleadReference)
                   // .ThenInclude(x => x.Designation)
                    .Include("CrmleadDetails.Trade").Include("CrmleadDetails.FAT").Include(x => x.LeadStatus)
                    .Include(x => x.LeadStatusComment).Include(x => x.CompanyType).Include(x => x.AssignedSalesExecutive).
                     ThenInclude(x => x.BasicDetail)
                      .Include(x => x.ProjectLocation)
                      .Include(x => x.CompanyLocation)
                      .Include(x => x.OfficePhoto)
                      .Include(x => x.ProjectSitePhoto)
                      .Include(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Emirates).Include(x => x.Designation).Include(x => x.Source)
                     .Include(x => x.CrmleadDocuments).ThenInclude(x => x.DocumentType)
                    .Include(x => x.CrmleadDocuments).ThenInclude(x => x.Attachment)
                    .Where(predicate)).OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToListAsync();
                 await (DBContext.CrmleadReference.Where(x => x.IsDeleted != 1 && x.Crmlead.BranchId == page.BranchId && (x.Crmlead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Include(x => x.Designation).ToListAsync());

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                if (page.StartIndex <= 1)
                {
                    var totalrecord = DBContext.Crmlead.Where(x => x.BranchId == page.BranchId && (x.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Where(predicate);
                    TotalNumberOfRows.Value = totalrecord.Count(); ;
                }
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(masterDataObject);
        }


        [HttpPost("GetAllAllCrmleadByPage")]
        public async Task<IActionResult> GetAllAllCrmleadByPage([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                var predicate = PredicateBuilder.New<Crmlead>(x => x.IsDeleted != 1);
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.CompanyName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Source.Source.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.LeadNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ContactPerson.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ProjectName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.ContactNumber.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.AssignedSalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower())
                     || x.Client.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower())
                    );
                }
                if ((page.Filters != null && page.Filters.Count > 0))
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "No":
                                predicate = predicate.And(x => x.LeadNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "CompanyName":
                                predicate = predicate.And(x => x.CompanyName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Source.Source":
                                predicate = predicate.And(x => x.Source.Source.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ContactPerson":
                                predicate = predicate.And(x => x.ContactPerson.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ContactNumber":
                                predicate = predicate.And(x => x.ContactNumber.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "ProjectName":
                                predicate = predicate.And(x => x.ProjectName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "AssignedSalesExecutive.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.AssignedSalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Client.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.Client.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "LeadStatusId":
                                predicate = predicate.And(x => x.LeadStatusId == Convert.ToInt64(val.Value));
                                break;
                        }
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////

                var result = await DBContext.Crmlead.Where(x => x.BranchId == page.BranchId && (x.AssignedSalesExecutiveId == page.UserId || page.UserId == 0))
                    .Where(predicate).Select(x => new
                    {
                        Id = x.Id,
                        x.IsDeleted,
                        x.LeadNo,
                        x.BranchId,
                        x.ClientId,
                        x.Date,
                        x.CompanyName,
                        x.IsClient,
                        x.IsFatown,
                        x.Longitude,
                        x.Latitude,
                        x.Pbno,
                        x.PhotoId,
						x.ModeOfCompletionId,
                        Photo = new
                        {
                            Id = x.Photo.Id,
                            x.Photo.FilePath
                        },
                        x.ProjectSitePhotoId,
                        ProjectSitePhoto = new
                        {
                            Id = x.ProjectSitePhoto.Id,
                            x.ProjectSitePhoto.FilePath
                        },
                        x.OfficePhotoId,
                        OfficePhoto = new {
                            Id =x.OfficePhoto.Id,
                            x.OfficePhoto.FilePath
                        },
                        Client = new
                        {
                            Id = x.ClientId,
                            x.Client.BasicDetail.IncorporatedName,
                            x.Client.BasicDetailId,
                            x.Client.UserRoleId,
                            x.Client.UserDetailsId,
                            x.Client.UserRoleRuleId
                        },
                        x.ProjectName,
                        x.ContactPerson,
                        x.WorkCategoryId,
                        x.AssignedSalesExecutiveId,
                        x.LeadStatusCommentId,
                        LeadStatusComment = new {
                            Id = x.LeadStatusComment.Id,
                            x.LeadStatusComment.Comment,
                            x.LeadStatusComment.IsDeleted
                        },
                        AssignedSalesExecutive = new
                        {
                            Id = x.AssignedSalesExecutive.Id,
                            x.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                            x.AssignedSalesExecutive.BasicDetail.FirstName,
                            x.AssignedSalesExecutive.BasicDetail.MiddleName,
                            x.AssignedSalesExecutive.BasicDetail.Pobox,
                            x.AssignedSalesExecutive.BasicDetail.EmailId,
                            MobileNo = x.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                            x.AssignedSalesExecutive.BasicDetailId,
                            x.AssignedSalesExecutive.UserRoleId,
                            x.AssignedSalesExecutive.UserDetailsId,
                            x.AssignedSalesExecutive.UserRoleRuleId
                        },
                        x.ProjectLocationId,
                        ProjectLocation = new
                        {
                            Id = x.ProjectLocation.Id,
                            x.ProjectLocation.Name
                        },
                        x.SourceId,
                        Source = new
                        {
                            Id = x.SourceId,
                            x.Source.Source
                        },
                        CrmleadReference = x.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                        {
                            Id = y.Id,
                            y.DefaultContact,
                            y.Name,
                            y.DesignationId,
                            Designation = new { Id = y.Designation.Id, y.Designation.Name },
                            y.ContactNo,
                            y.Email,
							y.CustomerReferenceId
                        }),
                        x.CompanyLocationId,
                        CompanyLocation = new
                        {
                            Id = x.CompanyLocation.Id,
                            x.CompanyLocation.Name
                        },
                        x.CompanyTypeId,
                        CompanyType = new
                        {
                            Id = x.CompanyType.Id,
                            x.CompanyType.Type,
                            x.CompanyType.IsDeleted
                        },
                        CrmleadDetails = x.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                        {
                            Id = y.Id,
                            FAT = new { Id = y.FAT.Id, y.FAT.Type },
                            y.FATId,
                            y.Trade,
                            y.TradeId,
                            y.Qty,
                            y.Rate,
                            y.TypeId,
                        }),
                        x.EmiratesId,
                        Emirates = new
                        {
                            Id = x.Emirates.Id,
                            x.Emirates.CountryId,
                            x.Emirates.ExtensionCode,
                            x.Emirates.Name,
                            x.Emirates.IsDeleted
                        },
                        x.IsActive,
                        x.LeadStatusId,
                        LeadStatus = new
                        { 
                            Id = x.LeadStatus.Id,
                            x.LeadStatus.CrmType,
                            x.LeadStatus.Status,
                            x.LeadStatus.IsDeleted
                        },
                        x.SponsorShipCompanyId,
                        x.TelNo,
                        x.WebSite,
                        CrmleadDocuments = x.CrmleadDocuments.Where(x => x.IsDeleted != 1).Select(y => new
                        {
                            Id = y.Id,
                            y.IsDeleted,
                            y.AttachmentId,
                            y.Description,
                            y.ExpiryDate,
                            y.LeadId,
                           y.DocumentTypeId,
                            DocumentType = new
                            {
                                Id = y.DocumentType.Id,
                                y.DocumentType.Type,
                                y.DocumentType.IsDeleted
                            },
                            Attachment = new
                            {
                                Id = y.Attachment.Id,
                                y.Attachment.FilePath,
                                y.Attachment.Description
                            }
                        }),
						LeadComments= x.LeadComments.Where(y => y.IsDeleted != 1).Select(y => new {
							y.Id,
							y.LeadId,
							y.CommentId,
							y.IsDeleted,
							CommentLabel = y.Comment.Comment
						}),

                    }).OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                if (page.StartIndex <= 1)
                {
                    var totalrecord = DBContext.Crmlead.Where(x => x.BranchId == page.BranchId && (x.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Where(predicate);
                    TotalNumberOfRows.Value = totalrecord.Count(); ;
                }
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(masterDataObject);
        }


        [HttpPost("InsertCrmlead")]
        public async Task<IActionResult> InsertCrmlead([FromBody] Crmlead Crmlead)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmleadId = new JProperty("Id", "");
            try
            {
                if (Crmlead.Id <= 0)
                {
                    var code = new CodeGenerator();
                    CodeGeneratorController generator = new CodeGeneratorController(DBContext);
                    var usercode = generator.Get(Crmlead.BranchId, _crmLeadNo);
                    var branch = (DBContext.Branch.Where(x => x.Id == Crmlead.BranchId).FirstOrDefault());
                    Crmlead.LeadNo = branch.CrmLeadPrefix + string.Format("{0,10:d4}", usercode.LatestCode);
                    Crmlead.LeadNo = Crmlead.LeadNo.Replace(" ", "");
                }
				if(Crmlead.CrmleadReference.Count()>0){
					var customerId = Crmlead.ClientId.Value;
					Crmlead.CrmleadReference = UpdateUserReferenceInCrmLeadReference(Crmlead.CrmleadReference,customerId);
				}
                var newUser = DBContext.Crmlead.Update(Crmlead);
                DBContext.SaveChanges();
                
                if (newUser.Entity.LeadStatusId == 13)
                {
                    var opportunity = new Crmopportunity
                    {
                        LeadId = newUser.Entity.Id,
                        AccountId = newUser.Entity.ClientId,
                        StatusId = 6,
                        //ProjectLocationId= newUser.Entity.ProjectLocationId ,
                        Contact = newUser.Entity.ContactPerson,
                        Date = newUser.Entity.Date,
                        //IsDeleted = newUser.Entity.IsDeleted,
                        OpportunityName = newUser.Entity.ProjectName,
                        BranchId = newUser.Entity.BranchId,
                        SponsorShipCompanyId = newUser.Entity.SponsorShipCompanyId,
                        //SalesExecutive = newUser.Entity.AssignedSalesExecutive,
                    };
                    InsertCrmopportunity(opportunity);
                }
                
                if (newUser.Entity.Id > 0)
                    return GetCrmlead(Crmlead.Id).Result;

            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmleadId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmlead")]
        public async Task<IActionResult> UpdateCrmlead([FromBody] Crmlead crmlead)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
				if(crmlead.CrmleadReference.Count()>0){
					var customerId = crmlead.ClientId.Value;
					crmlead.CrmleadReference = UpdateUserReferenceInCrmLeadReference(crmlead.CrmleadReference,customerId);
				}
                DBContext.Crmlead.Update(crmlead);
                DBContext.SaveChanges();
                if (crmlead.LeadStatusId == 13)
                {
                    var opportunity = new Crmopportunity
                    {
                        
                        LeadId = crmlead.Id,
                        AccountId = crmlead.ClientId,
                        StatusId = 6,
                        //ProjectLocationId=crmlead.ProjectLocationId ,
                        //Comments = "",
                        Contact = crmlead.ContactPerson,
                        Date = crmlead.Date,
                        IsDeleted = crmlead.IsDeleted,
                        OpportunityName = crmlead.ProjectName,
                       // ProjectLocation = crmlead.ProjectLocation,
                        BranchId = crmlead.BranchId,
                        SponsorShipCompanyId = crmlead.SponsorShipCompanyId,
                        //SalesExecutive = crmlead.AssignedSalesExecutive,
                    };
                    InsertCrmopportunity(opportunity);
                }
                if (crmlead.Id > 0)
                {
                    return await GetCrmlead(crmlead.Id);
                }
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmlead")]
        public async Task<IActionResult> DeleteCrmlead([FromBody] Crmlead Crmlead)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                Crmlead.IsDeleted = 1;
                DBContext.Crmlead.Update(Crmlead);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

		private ICollection<CrmleadReference> UpdateUserReferenceInCrmLeadReference(ICollection<CrmleadReference> references,long customerId){
			foreach (CrmleadReference reference in references)
					{
						if(reference.Id <= 0 && reference.CustomerReferenceId == null){
							UserRefrence newUserReference = new UserRefrence() { 
								Name =reference.Name,
								ContactNo =reference.ContactNo,
								Email =reference.Email,
								IsDeleted =reference.IsDeleted,
								DesignationId =reference.DesignationId,
								UserId = customerId,
							};
							reference.CustomerReference = newUserReference;
						}
						if (reference.Id >= 0 && reference.CustomerReferenceId != null)
						{
							UserRefrence newUserReference = new UserRefrence() {
								Id = reference.CustomerReferenceId.Value, 
								Name =reference.Name,
								ContactNo =reference.ContactNo,
								Email =reference.Email,
								IsDeleted =reference.IsDeleted,
								DesignationId =reference.DesignationId,
								UserId = customerId,
							};
							reference.CustomerReference = newUserReference;
						}
					}
			return references;
		}

        #endregion CRMLead 

        [HttpGet("GetCrmleadComments/{Id}")]
        public async Task<IActionResult> GetCrmleadComments(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadComments
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmleadComments")]
        public async Task<IActionResult> GetAllCrmleadComments()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadComments
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmleadComments")]
        public async Task<IActionResult> InsertCrmleadComments([FromBody] CrmleadComments CrmleadComments)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmleadCommentsId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmleadComments.Update(CrmleadComments);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmleadCommentsId.Value = newUser.Entity.Id;
                }
                else
                    CrmleadCommentsId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmleadCommentsId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmleadComments")]
        public async Task<IActionResult> UpdateCrmleadComments([FromBody] CrmleadComments CrmleadComments)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmleadComments.Update(CrmleadComments);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmleadComments")]
        public async Task<IActionResult> DeleteCrmleadComments([FromBody] CrmleadComments CrmleadComments)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmleadComments.IsDeleted = 1;
                DBContext.CrmleadComments.Update(CrmleadComments);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #region CrmleadDetails
        [HttpGet("GetCrmleadDetails/{Id}")]
        public async Task<IActionResult> GetCrmleadDetails(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadDetails
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmleadDetails")]
        public async Task<IActionResult> GetAllCrmleadDetails()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadDetails
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmleadDetails")]
        public async Task<IActionResult> InsertCrmleadDetails([FromBody] CrmleadDetails CrmleadDetails)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmleadDetailsId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmleadDetails.Update(CrmleadDetails);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmleadDetailsId.Value = newUser.Entity.Id;
                }
                else
                    CrmleadDetailsId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmleadDetailsId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmleadDetails")]
        public async Task<IActionResult> UpdateCrmleadDetails([FromBody] CrmleadDetails CrmleadDetails)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmleadDetails.Update(CrmleadDetails);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmleadDetails")]
        public async Task<IActionResult> DeleteCrmleadDetails([FromBody] CrmleadDetails CrmleadDetails)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmleadDetails.IsDeleted = 1;
                DBContext.CrmleadDetails.Update(CrmleadDetails);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #endregion CrmleadDetails

        [HttpGet("GetCrmleadSource/{Id}")]
        public async Task<IActionResult> GetCrmleadSource(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadSource
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmleadSource")]
        public async Task<IActionResult> GetAllCrmleadSource()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadSource
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmleadSource")]
        public async Task<IActionResult> InsertCrmleadSource([FromBody] CrmleadSource CrmleadSource)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmleadSourceId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmleadSource.Update(CrmleadSource);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmleadSourceId.Value = newUser.Entity.Id;
                }
                else
                    CrmleadSourceId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmleadSourceId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmleadSource")]
        public async Task<IActionResult> UpdateCrmleadSource([FromBody] CrmleadSource CrmleadSource)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmleadSource.Update(CrmleadSource);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmleadSource")]
        public async Task<IActionResult> DeleteCrmleadSource([FromBody] CrmleadSource CrmleadSource)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmleadSource.IsDeleted = 1;
                DBContext.CrmleadSource.Update(CrmleadSource);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #region CRMopportunity

        [HttpGet("GetCrmopportunity/{Id}")]
        public async Task<IActionResult> GetCrmopportunity(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                //var result = await (DBContext.Crmopportunity
                //    .Where(x => x.Id == Id && x.IsDeleted != 1)).Include(x => x.CrmopportunityTerms)
                //    .Include(x => x.SponsorShipCompany).ThenInclude(x => x.Crmceal)
                //    .Include(x => x.Lead)
                //    .ThenInclude(x => x.CrmleadDetails)
                //    .Include("Lead.CrmleadReference")
                //    .Include("Lead.CrmleadReference.Designation")
                //    .Include("Lead.CrmleadDetails.Trade")
                //    .Include("Lead.CrmleadDetails.FAT")
                //    .Include("Lead.ProjectLocation")
                //    .Include("Lead.Source")
                //    .Include(x => x.Owner).ThenInclude(x => x.BasicDetail)
                //    .Include(x => x.Status).Include(x => x.Account).ThenInclude(x => x.BasicDetail)
                //    .ToListAsync();

                var result = await DBContext.Crmopportunity.Where(x => x.Id == Id && x.IsDeleted != 1)
               .Select(x => new
               {
                   x.Id,
                   x.LeadId,
                   x.OpportunityName,
                   x.OpportunityNumber,
                   Lead = new
                   {
                       Id = x.Lead.Id,
                       x.Lead.ClientId,
                       x.Lead.LeadNo,
                       CrmleadDetails = x.Lead.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                       {
                           FAT = new { Id = y.FAT.Id, y.FAT.Type },
                           y.FATId,
                           y.Trade,
                           y.TradeId,
                           y.Qty,
                           y.Rate,
                           y.TypeId
                       }),
                       Client = new
                       {
                           Id = x.Lead.ClientId,
                           x.Lead.Client.BasicDetail.IncorporatedName,
                           x.Lead.Client.BasicDetailId,
                           x.Lead.Client.UserRoleId,
                           x.Lead.Client.UserDetailsId,
                           x.Lead.Client.UserRoleRuleId
                       },
                       x.Lead.ProjectName,
                       x.Lead.ContactPerson,
                       x.Lead.WorkCategoryId,
                       x.Lead.AssignedSalesExecutiveId,
                       AssignedSalesExecutive = new
                       {
                           Id = x.Lead.AssignedSalesExecutive.Id,
                           x.Lead.AssignedSalesExecutive.BasicDetail.FirstName,
                           x.Lead.AssignedSalesExecutive.BasicDetail.MiddleName,
                           x.Lead.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                           x.Lead.AssignedSalesExecutive.BasicDetail.Pobox,
                           x.Lead.AssignedSalesExecutive.BasicDetail.EmailId,
                           MobileNo = x.Lead.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                           x.Lead.AssignedSalesExecutive.BasicDetailId,
                           x.Lead.AssignedSalesExecutive.UserRoleId,
                           x.Lead.AssignedSalesExecutive.UserDetailsId,
                           x.Lead.AssignedSalesExecutive.UserRoleRuleId,
						   x.Lead.AssignedSalesExecutive.BasicDetail.SignatureId,
						   x.Lead.AssignedSalesExecutive.BasicDetail.Code,

                       },
                       x.Lead.ProjectLocationId,
                       ProjectLocation = new
                       {
                           Id = x.Lead.ProjectLocation.Id,
                           x.Lead.ProjectLocation.Name
                       },
                       x.Lead.SourceId,
                       Source = new
                       {
                           Id = x.Lead.SourceId,
                           x.Lead.Source.Source
                       },
                       CrmleadReference = x.Lead.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                       {
                           y.Id,
                           y.DefaultContact,
                           y.Name,
                           y.DesignationId,
                           Designation = new { Id = y.Designation.Id, y.Designation.Name },
                           y.ContactNo,
                           y.Email
                       }),
                       x.Lead.CompanyLocationId,
                       CompanyLocation = new
                       {
                           Id = x.Lead.CompanyLocation.Id,
                           x.Lead.CompanyLocation.Name
                       },

                   },
                   Account = new
                   {
                       Id = x.Account.Id,
                       x.Account.BasicDetail.IncorporatedName,
                       x.Account.BasicDetail.Pobox,
                       Country = x.Account.BasicDetail.Country != null ? x.Account.BasicDetail.Country.Name : "",
                       Emirates = x.Account.BasicDetail.Emirates != null ? x.Account.BasicDetail.Emirates.Name : "",
                       MobileNo = x.Account.BasicDetail.TelephoneNo,
                       x.Account.BasicDetail.EmailId,
                       x.Account.BasicDetail.Code,
                       x.Account.BasicDetail.FaxNumber,
                       x.Account.BasicDetailId,
                       x.Account.UserRoleId,
                       x.Account.UserDetailsId,
                       x.Account.UserRoleRuleId
                   },
                   x.StatusId,
                   Status = new
                   {
                       Id = x.Status.Id,
                       x.Status.Status
                   },
                   x.OwnerId,
                   Owner = new
                   {
                       Id = x.Owner.Id,
                       x.Owner.BasicDetail.IncorporatedName,
                       x.Owner.BasicDetail.FirstName,
                       x.Owner.BasicDetail.MiddleName,
                       x.Owner.BasicDetailId,
                       x.Owner.UserRoleId,
                       x.Owner.UserDetailsId,
                       x.Owner.UserRoleRuleId
                   },
                   x.Comments,

                   CrmopportunityTerms = x.CrmopportunityTerms.Select(y => new { y.Id, y.Terms }),
                   x.Date,
                   x.IsDeleted,
                   x.BranchId,
                   x.SponsorShipCompanyId,
                   SponsorShipCompany = new
                   {
                       Id = x.SponsorShipCompany.Id,
                       x.SponsorShipCompany.Name,
                       Crmceal = new { Id = x.SponsorShipCompany.Crmceal.Id, x.SponsorShipCompany.Crmceal.FilePath, x.SponsorShipCompany.Crmceal.Description },
                       x.SponsorShipCompany.CrmcealId,
                       x.SponsorShipCompany.ReportFooterId,
                       x.SponsorShipCompany.ReportHeaderId
                   },

                   x.Contact,
                   x.AccountId
               }).ToListAsync();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmopportunity")]
        public async Task<IActionResult> GetAllCrmopportunity()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                //var result = await (DBContext.Crmopportunity
                //    .Where(x => x.IsDeleted != 1)).Include(x => x.CrmopportunityTerms)
                //    .Include(x => x.SponsorShipCompany).ThenInclude(x => x.Crmceal)
                //     .Include(x => x.Lead)
                //    .ThenInclude(x => x.CrmleadDetails)
                //     .Include("Lead.CrmleadReference")
                //    .Include("Lead.CrmleadReference.Designation")
                //    .Include("Lead.CrmleadDetails.Trade")
                //    .Include("Lead.CrmleadDetails.FAT")
                //    .Include("Lead.ProjectLocation")
                //     .Include("Lead.AssignedSalesExecutive")
                //     .Include("Lead.AssignedSalesExecutive.BasicDetail")
                //    .Include("Lead.Source")
                //    .Include(x => x.Owner).ThenInclude(x => x.BasicDetail)
                //    .Include(x => x.Status).Include(x => x.Account).ThenInclude(x => x.BasicDetail)
                //    .OrderByDescending(x => x.Id).ToListAsync();
                var result = await DBContext.Crmopportunity.Where(x => x.IsDeleted != 1)
                 .Select(x => new
                 {
                     x.Id,
                     x.LeadId,
                     x.OpportunityName,
                     x.OpportunityNumber,
                     Lead = new
                     {
                         Id = x.Lead.Id,
                         x.Lead.ClientId,
                         x.Lead.LeadNo,
                         CrmleadDetails = x.Lead.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                         {
                             FAT = new { Id = y.FAT.Id, y.FAT.Type },
                             y.FATId,
                             y.Trade,
                             y.TradeId,
                             y.Qty,
                             y.Rate,
                             y.TypeId
                         }),
                         Client = new
                         {
                             Id = x.Lead.ClientId,
                             x.Lead.Client.BasicDetail.IncorporatedName,
                             x.Lead.Client.BasicDetailId,
                             x.Lead.Client.UserRoleId,
                             x.Lead.Client.UserDetailsId,
                             x.Lead.Client.UserRoleRuleId
                         },
                         x.Lead.ProjectName,
                         x.Lead.ContactPerson,
                         x.Lead.WorkCategoryId,
                         x.Lead.AssignedSalesExecutiveId,
                         AssignedSalesExecutive = new
                         {
                             Id = x.Lead.AssignedSalesExecutive.Id,
                             x.Lead.AssignedSalesExecutive.BasicDetail.FirstName,
                             x.Lead.AssignedSalesExecutive.BasicDetail.MiddleName,
                             x.Lead.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                             x.Lead.AssignedSalesExecutive.BasicDetail.Pobox,
                             x.Lead.AssignedSalesExecutive.BasicDetail.EmailId,
                             MobileNo = x.Lead.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                             x.Lead.AssignedSalesExecutive.BasicDetailId,
                             x.Lead.AssignedSalesExecutive.UserRoleId,
                             x.Lead.AssignedSalesExecutive.UserDetailsId,
                             x.Lead.AssignedSalesExecutive.UserRoleRuleId
                         },
                         x.Lead.ProjectLocationId,
                         ProjectLocation = new
                         {
                             Id = x.Lead.ProjectLocation.Id,
                             x.Lead.ProjectLocation.Name
                         },
                         x.Lead.SourceId,
                         Source = new
                         {
                             Id = x.Lead.SourceId,
                             x.Lead.Source.Source
                         },
                         CrmleadReference = x.Lead.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                         {
                             y.Id,
                             y.DefaultContact,
                             y.Name,
                             y.DesignationId,
                             Designation = new { Id = y.Designation.Id, y.Designation.Name },
                             y.ContactNo,
                             y.Email
                         }),
                         x.Lead.CompanyLocationId,
                         CompanyLocation = new
                         {
                             Id = x.Lead.CompanyLocation.Id,
                             x.Lead.CompanyLocation.Name
                         },

                     },
                     Account = new
                     {
                         Id = x.Account.Id,
                         x.Account.BasicDetail.IncorporatedName,
                         x.Account.BasicDetail.Pobox,
                         Country = x.Account.BasicDetail.Country != null ? x.Account.BasicDetail.Country.Name : "",
                         Emirates = x.Account.BasicDetail.Emirates != null ? x.Account.BasicDetail.Emirates.Name : "",
                         MobileNo = x.Account.BasicDetail.TelephoneNo,
                         x.Account.BasicDetail.EmailId,
                         x.Account.BasicDetail.Code,
                         x.Account.BasicDetail.FaxNumber,
                         x.Account.BasicDetailId,
                         x.Account.UserRoleId,
                         x.Account.UserDetailsId,
                         x.Account.UserRoleRuleId
                     },
                     x.StatusId,
                     Status = new
                     {
                         Id = x.Status.Id,
                         x.Status.Status
                     },
                     x.OwnerId,
                     Owner = new
                     {
                         Id = x.Owner.Id,
                         x.Owner.BasicDetail.IncorporatedName,
                         x.Owner.BasicDetail.FirstName,
                         x.Owner.BasicDetail.MiddleName,
                         x.Owner.BasicDetailId,
                         x.Owner.UserRoleId,
                         x.Owner.UserDetailsId,
                         x.Owner.UserRoleRuleId
                     },
                     x.Comments,

                     CrmopportunityTerms = x.CrmopportunityTerms.Select(y => new { y.Id, y.Terms }),
                     x.Date,
                     x.IsDeleted,
                     x.BranchId,
                     x.SponsorShipCompanyId,
                     SponsorShipCompany = new
                     {
                         Id = x.SponsorShipCompany.Id,
                         x.SponsorShipCompany.Name,
                         Crmceal = new { Id = x.SponsorShipCompany.Crmceal.Id, x.SponsorShipCompany.Crmceal.FilePath, x.SponsorShipCompany.Crmceal.Description },
                         x.SponsorShipCompany.CrmcealId,
                         x.SponsorShipCompany.ReportFooterId,
                         x.SponsorShipCompany.ReportHeaderId
                     },

                     x.Contact,
                     x.AccountId
                 }).OrderByDescending(x => x.Id).ToListAsync();


                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("GetAllCrmopportunityByPage1")]
        public async Task<IActionResult> GetAllCrmopportunityByPage1([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                var predicate = PredicateBuilder.New<Crmopportunity>(x => x.IsDeleted != 1);
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.OpportunityName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.OpportunityNumber.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Lead.ProjectName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Status.Status.ToLower().Contains(page.GlobalFilter.ToLower())
                    );
                }
                if ((page.Filters != null && page.Filters.Count > 0))
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "OpportunityName":
                                predicate = predicate.And(x => x.Lead.LeadNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "OpportunityNumber":
                                predicate = predicate.And(x => x.OpportunityNumber.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Lead.ProjectName":
                                predicate = predicate.And(x => x.Lead.ProjectName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Status.Status":
                                predicate = predicate.And(x => x.Status.Status.ToLower().Contains(val.Value.ToLower()));
                                break;
                        }
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                var result = await (DBContext.Crmopportunity.Include(x => x.Lead)
                      .Where(x => x.BranchId == page.BranchId && (x.Lead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0))
                    .Include(x => x.Owner.BasicDetail).Include(x => x.Status)
                    .Where(predicate))
                    .Include(x => x.SponsorShipCompany).ThenInclude(x => x.Crmceal)
                    .Include(x => x.CrmopportunityTerms)
                    .Include(x => x.Lead)
                    .ThenInclude(x => x.CrmleadDetails)
                   // .Include("Lead.CrmleadReference")
                    //.Include("Lead.CrmleadReference.Designation")
                    //.Include("Lead.CrmleadReference")
                    .Include("Lead.CrmleadDetails.Trade")
                    .Include("Lead.CrmleadDetails.FAT")
                    .Include("Lead.ProjectLocation")
                    .Include("Lead.Source")
                    .Include("Lead.AssignedSalesExecutive")
                    .Include("Lead.AssignedSalesExecutive.BasicDetail")
                    .Include(x => x.Lead).ThenInclude(x => x.CompanyLocation)
                    .Include(x => x.Owner).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Status).Include(x => x.Account).ThenInclude(x => x.BasicDetail).
                    OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToListAsync();
                await (DBContext.CrmleadReference.Where(x => x.IsDeleted != 1 && x.Crmlead.BranchId== page.BranchId && (x.Crmlead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Include(x => x.Designation).ToListAsync());
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                if (page.StartIndex <= 1)
                {
                    var totalrecord = DBContext.Crmopportunity.Count(x => x.IsDeleted != 1);
                    TotalNumberOfRows.Value = totalrecord;
                }
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(masterDataObject);
        }


        [HttpPost("GetAllCrmopportunityByPage")]
        public async Task<IActionResult> GetAllCrmopportunityByPage([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                var predicate = PredicateBuilder.New<Crmopportunity>(x => x.IsDeleted != 1);
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.OpportunityName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.OpportunityNumber.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                    x.Lead.LeadNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Status.Status.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.OpportunityName.ToLower().Contains(page.GlobalFilter.ToLower()) 
                    );
                }
                if ((page.Filters != null && page.Filters.Count > 0))
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "Lead.LeadNo":
                                predicate = predicate.And(x => x.Lead.LeadNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "OpportunityName":
                                predicate = predicate.And(x => x.OpportunityName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "OpportunityNumber":
                                predicate = predicate.And(x => x.OpportunityNumber.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Status.Status":
                                predicate = predicate.And(x => x.Status.Status.ToLower().Contains(val.Value.ToLower()));
                                break;
                        }
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
              //  var completeStatusList = await DBContext.Crmlead.Where(x => x.LeadStatusId == 13).Select(x => x.Id).ToListAsync();

                var result = await DBContext.Crmopportunity.Where(predicate).Where(x => x.BranchId == page.BranchId && x.IsDeleted != 1
                && (x.Lead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0))
               // && completeStatusList.Contains((long)x.LeadId))
                      .Select(x => new
                      {
                          x.Id,
                          x.LeadId,
                          x.OpportunityName,
                          x.OpportunityNumber,
                          Lead = new
                          {
                              Id = x.Lead.Id,
                              x.Lead.ClientId,
                              x.Lead.LeadNo,
                              CrmleadDetails = x.Lead.CrmleadDetails.Where(y => y.IsDeleted != 1).Select(y => new
                              {
                                  FAT = new { Id = y.FAT.Id, y.FAT.Type },
                                  y.FATId,
                                  y.Trade,
                                  y.TradeId,
                                  y.Qty,
                                  y.Rate,
                                  y.TypeId
                              }),
                              Client = new
                              {
                                  Id = x.Lead.ClientId,
                                  x.Lead.Client.BasicDetail.IncorporatedName,
                                  x.Lead.Client.BasicDetailId,
                                  x.Lead.Client.UserRoleId,
                                  x.Lead.Client.UserDetailsId,
                                  x.Lead.Client.UserRoleRuleId
                              },
                              x.Lead.ProjectName,
                              x.Lead.ContactPerson,
                              x.Lead.WorkCategoryId,
                              x.Lead.AssignedSalesExecutiveId,
                              AssignedSalesExecutive = new
                              {
                                  Id = x.Lead.AssignedSalesExecutive.Id,
                                  x.Lead.AssignedSalesExecutive.BasicDetail.FirstName,
                                  x.Lead.AssignedSalesExecutive.BasicDetail.MiddleName,
                                  x.Lead.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                                  x.Lead.AssignedSalesExecutive.BasicDetail.Pobox,
                                  x.Lead.AssignedSalesExecutive.BasicDetail.EmailId,
                                  MobileNo=x.Lead.AssignedSalesExecutive.BasicDetail.LocalCompanyMobileNo,
                                  x.Lead.AssignedSalesExecutive.BasicDetailId,
                                  x.Lead.AssignedSalesExecutive.UserRoleId,
                                  x.Lead.AssignedSalesExecutive.UserDetailsId,
                                  x.Lead.AssignedSalesExecutive.UserRoleRuleId,
								  x.Lead.AssignedSalesExecutive.BasicDetail.SignatureId,
								  x.Lead.AssignedSalesExecutive.BasicDetail.Code,
                              },
                              x.Lead.ProjectLocationId,
                              ProjectLocation = new
                              {
                                  Id = x.Lead.ProjectLocation.Id,
                                  x.Lead.ProjectLocation.Name
                              },
                              x.Lead.SourceId,
                              Source = new
                              {
                                  Id = x.Lead.SourceId,
                                  x.Lead.Source.Source
                              },
                              CrmleadReference = x.Lead.CrmleadReference.Where(y => y.IsDeleted != 1).Select(y => new
                              {
                                  y.Id,
                                  y.DefaultContact,
                                  y.Name,
                                  y.DesignationId,
                                  Designation = new { Id = y.Designation.Id, y.Designation.Name },
                                  y.ContactNo,
                                  y.Email
                              }),
                              x.Lead.CompanyLocationId,
                              CompanyLocation = new
                              {
                                  Id = x.Lead.CompanyLocation.Id,
                                  x.Lead.CompanyLocation.Name
                              },
                             
                          },
                          Account = new
                          {
                              Id = x.Account.Id,
                              x.Account.BasicDetail.IncorporatedName,
                              x.Account.BasicDetail.Pobox,
                              Country = x.Account.BasicDetail.Country != null ? x.Account.BasicDetail.Country.Name : "",
                              Emirates = x.Account.BasicDetail.Emirates!= null ? x.Account.BasicDetail.Emirates.Name : "",
                              MobileNo = x.Account.BasicDetail.TelephoneNo,
                              x.Account.BasicDetail.EmailId,
                              x.Account.BasicDetail.Code,
                              x.Account.BasicDetail.FaxNumber,
                              x.Account.BasicDetailId,
                              x.Account.UserRoleId,
                              x.Account.UserDetailsId,
                              x.Account.UserRoleRuleId
                          },
                          x.StatusId,
                          Status = new
                          {
                              Id = x.Status.Id,
                              x.Status.Status
                          },
                          x.OwnerId,
                          Owner = new
                          {
                              Id = x.Owner.Id,
                              x.Owner.BasicDetail.IncorporatedName,
                              x.Owner.BasicDetail.FirstName,
                              x.Owner.BasicDetail.MiddleName,
                              x.Owner.BasicDetailId,
                              x.Owner.UserRoleId,
                              x.Owner.UserDetailsId,
                              x.Owner.UserRoleRuleId
                          },
                          x.Comments,

                          CrmopportunityTerms = x.CrmopportunityTerms.Select(y => new { y.Id, y.Terms }),
                          x.Date,
                          x.IsDeleted,
                          x.BranchId,
                          x.SponsorShipCompanyId,
                          SponsorShipCompany = new
                          {
                              Id = x.SponsorShipCompany.Id,
                              x.SponsorShipCompany.Name,
                              Crmceal = new { Id = x.SponsorShipCompany.Crmceal.Id, x.SponsorShipCompany.Crmceal.FilePath, x.SponsorShipCompany.Crmceal.Description },
                              x.SponsorShipCompany.CrmcealId,
                              x.SponsorShipCompany.ReportFooterId,
                              x.SponsorShipCompany.ReportHeaderId
                          },

                          x.Contact,
                          x.AccountId
                      }).OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToListAsync();



              //  await (DBContext.CrmleadReference.Where(x => x.IsDeleted != 1 && x.Crmlead.BranchId == page.BranchId && (x.Crmlead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Include(x => x.Designation).ToListAsync());
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

                if (page.StartIndex <= 1)
                {
                    var totalrecord = DBContext.Crmopportunity.Where(x => x.BranchId == page.BranchId && (x.Lead.AssignedSalesExecutiveId == page.UserId || page.UserId == 0)).Where(predicate);
                    TotalNumberOfRows.Value = totalrecord.Count(); ;
                }
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(masterDataObject);
        }


        [HttpPost("InsertCrmopportunity")]
        public async Task<IActionResult> InsertCrmopportunity([FromBody] Crmopportunity Crmopportunity)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmopportunityId = new JProperty("Id", "");
            try
            {
                if (Crmopportunity.Id <= 0 && Crmopportunity.LeadId > 0)
                {
                    var code = new CodeGenerator();
                    CodeGeneratorController generator = new CodeGeneratorController(DBContext);
                    var lead = DBContext.Crmlead.Where(x => x.Id == Crmopportunity.LeadId).FirstOrDefault();
                    if (lead != null)
                    {
                        string prefix = "";
                        var usercode = generator.Get(lead.BranchId, _crmLeadNo);
                        var branch = (DBContext.Branch.Where(x => x.Id == lead.BranchId).FirstOrDefault());
                        if(branch.Id==1)
                        {
                            prefix = "WS/QT/";
                        }
                        else if (branch.Id == 2)
                        {
                            prefix = "MMS/QT/";
                        }
                        else if(branch.Id == 3)
                        {
                            prefix = (lead.WorkCategoryId == 1) ? "WSM/QT/" : "WSG/QT/";
                        }
                        Crmopportunity.OpportunityNumber = prefix + string.Format("{0,10:d4}", usercode.LatestCode);
                        Crmopportunity.OpportunityNumber = Crmopportunity.OpportunityNumber.Replace(" ", "");
                    }

                }
                var newUser = DBContext.Crmopportunity.Update(Crmopportunity);
                DBContext.SaveChanges();
                if (newUser.Entity.Id > 0)
                    return GetCrmopportunity(Crmopportunity.Id).Result;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmopportunityId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmopportunity")]
        public async Task<IActionResult> UpdateCrmopportunity([FromBody] Crmopportunity Crmopportunity)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.Crmopportunity.Update(Crmopportunity);
                DBContext.SaveChanges();
                return GetCrmopportunity(Crmopportunity.Id).Result;
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmopportunity")]
        public async Task<IActionResult> DeleteCrmopportunity([FromBody] Crmopportunity Crmopportunity)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                Crmopportunity.IsDeleted = 1;
                DBContext.Crmopportunity.Update(Crmopportunity);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #endregion CRMOpportunity

        [HttpGet("GetCrmopportunityDetail/{Id}")]
        public async Task<IActionResult> GetCrmopportunityDetail(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmopportunityDetail
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmopportunityDetail")]
        public async Task<IActionResult> GetAllCrmopportunityDetail()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmopportunityDetail
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmopportunityDetail")]
        public async Task<IActionResult> InsertCrmopportunityDetail([FromBody] CrmopportunityDetail CrmopportunityDetail)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmopportunityDetailId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmopportunityDetail.Update(CrmopportunityDetail);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmopportunityDetailId.Value = newUser.Entity.Id;
                }
                else
                    CrmopportunityDetailId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmopportunityDetailId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmopportunityDetail")]
        public async Task<IActionResult> UpdateCrmopportunityDetail([FromBody] CrmopportunityDetail CrmopportunityDetail)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmopportunityDetail.Update(CrmopportunityDetail);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmopportunityDetail")]
        public async Task<IActionResult> DeleteCrmopportunityDetail([FromBody] CrmopportunityDetail CrmopportunityDetail)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmopportunityDetail.IsDeleted = 1;
                DBContext.CrmopportunityDetail.Update(CrmopportunityDetail);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmpriority/{Id}")]
        public async Task<IActionResult> GetCrmpriority(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmpriority
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmpriority")]
        public async Task<IActionResult> GetAllCrmpriority()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmpriority
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmpriority")]
        public async Task<IActionResult> InsertCrmpriority([FromBody] Crmpriority Crmpriority)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmpriorityId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.Crmpriority.Update(Crmpriority);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmpriorityId.Value = newUser.Entity.Id;
                }
                else
                    CrmpriorityId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmpriorityId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmpriority")]
        public async Task<IActionResult> UpdateCrmpriority([FromBody] Crmpriority Crmpriority)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.Crmpriority.Update(Crmpriority);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmpriority")]
        public async Task<IActionResult> DeleteCrmpriority([FromBody] Crmpriority Crmpriority)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                Crmpriority.IsDeleted = 1;
                DBContext.Crmpriority.Update(Crmpriority);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmpurpose/{Id}")]
        public async Task<IActionResult> GetCrmpurpose(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmpurpose
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmpurpose")]
        public async Task<IActionResult> GetAllCrmpurpose()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmpurpose
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmpurpose")]
        public async Task<IActionResult> InsertCrmpurpose([FromBody] Crmpurpose Crmpurpose)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmpurposeId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.Crmpurpose.Update(Crmpurpose);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmpurposeId.Value = newUser.Entity.Id;
                }
                else
                    CrmpurposeId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmpurposeId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmpurpose")]
        public async Task<IActionResult> UpdateCrmpurpose([FromBody] Crmpurpose Crmpurpose)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.Crmpurpose.Update(Crmpurpose);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmpurpose")]
        public async Task<IActionResult> DeleteCrmpurpose([FromBody] Crmpurpose Crmpurpose)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                Crmpurpose.IsDeleted = 1;
                DBContext.Crmpurpose.Update(Crmpurpose);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmtask/{Id}")]
        public async Task<IActionResult> GetCrmtask(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmtask
                    .Where(x => x.Id == Id && x.IsDeleted != 1))
                    .Include(x => x.TaskOwner).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Client).ThenInclude(x => x.BasicDetail)
                     .Include(x => x.TaskType)
                     .Include(x => x.Purpose)
                     .Include(x => x.Priority)
                     .Include(x => x.Lead).ThenInclude(x => x.Client).ThenInclude(x => x.BasicDetail)
                      .Include(x => x.CrmtaskDocument)
                      .Include(x => x.CrmtaskDetail)
                        .Include(x => x.TaskAssignedByNavigation).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.TaskAssignedToNavigation).ThenInclude(x => x.BasicDetail)
                    .Include("CrmtaskDetail.Status")
                    .Include("CrmtaskDetail.TaskType")
                     .Include(x => x.Status)
                    .ToListAsync();
                if (result != null && result.Count > 0)
                {
                    result.ForEach(x =>
                    {
                        //    x.Project = x.TaskOnId == 1 && x.LeadId != null ?
                        //DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                        x.Opportunity = x.TaskOnId == 2 && x.OpportunityId != null ?
                    DBContext.Crmopportunity.Where(y => y.Id == x.OpportunityId).FirstOrDefault() : new Crmopportunity();
                        x.Project = x.TaskOnId == 3 && x.ProjectId != null ?
                        DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                    });
                }
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmtask")]
        public async Task<IActionResult> GetAllCrmtask()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.Crmtask
                    .Where(x => x.IsDeleted != 1))
                          .Include(x => x.TaskOwner).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Client).ThenInclude(x => x.BasicDetail)

                     .Include(x => x.TaskType)
                     .Include(x => x.CrmtaskDocument)
                      .Include(x => x.CrmtaskDetail)
                        .Include(x => x.TaskAssignedByNavigation).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.TaskAssignedToNavigation).ThenInclude(x => x.BasicDetail)
                    .Include("CrmtaskDetail.Status")
                    .Include("CrmtaskDetail.TaskType")
                     .Include(x => x.Status)
                     .Include(x => x.Purpose)
                     .Include(x => x.Lead)

                     .Include(x => x.Priority).OrderByDescending(x => x.Id).ToListAsync();
                if (result != null && result.Count > 0)
                {
                    result.ForEach(x =>
                    {
                        //    x.Project = x.TaskOnId == 1 && x.LeadId != null ?
                        //DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                        x.Opportunity = x.TaskOnId == 2 && x.OpportunityId != null ?
                    DBContext.Crmopportunity.Where(y => y.Id == x.OpportunityId).FirstOrDefault() : new Crmopportunity();
                        x.Project = x.TaskOnId == 3 && x.ProjectId != null ?
                        DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                    });
                }
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("GetAllGetAllCrmtaskByPage")]
        public async Task<IActionResult> GetAllGetAllCrmtaskByPage([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                var predicate = PredicateBuilder.New<Crmtask>(x => x.IsDeleted != 1);
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.Lead.LeadNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Lead.LeadNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     //x.Date.Value!=null?x.Date.Value.ToShortDateString().ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.TaskType.Type.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Purpose.Purpose.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.TaskOwner.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.Priority.Priority.ToLower().Contains(page.GlobalFilter.ToLower())
                    );
                }
                if ((page.Filters != null && page.Filters.Count > 0))
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "CaseId":
                                predicate = predicate.And(x => x.CaseId.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Lead.LeadNo":
                                predicate = predicate.And(x => x.Lead.LeadNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "TaskOn":
                                predicate = predicate.And(x => x.Lead.Client.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()))
                                    .Or(x => x.Opportunity.OpportunityName.ToLower().Contains(val.Value.ToLower()))
                                    .Or(x => x.Project.ProjectName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "CrmCustomer.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.Client.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Date":
                                // predicate = predicate.And(x => x.Date.Value != null ? x.Date.Value.ToShortDateString().ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "TaskType.Type":
                                predicate = predicate.And(x => x.TaskType.Type.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Purpose.Purpose":
                                predicate = predicate.And(x => x.Purpose.Purpose.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "TaskOwner.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.TaskOwner.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "Priority.Priority":
                                predicate = predicate.And(x => x.Priority.Priority.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "StatusId":
                                predicate = predicate.And(x => x.StatusId == Convert.ToInt64(val.Value));
                                break;
                        }
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                var result = await (DBContext.Crmtask
                      .Where(x => x.BranchId == page.BranchId && (x.TaskAssignedTo == page.UserId || page.UserId == 0))
                          .Include(x => x.TaskOwner).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.TaskAssignedByNavigation).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.TaskAssignedToNavigation).ThenInclude(x => x.BasicDetail)
                    .Include("CrmtaskDetail.Status")
                    .Include("CrmtaskDetail.TaskType")
                     .Include(x => x.Status)

                    .Include(x => x.CrmtaskDocument)
                      .Include(x => x.CrmtaskDetail)
                     .Include(x => x.TaskType)
                     .Include(x => x.Purpose)
                     .Include(x => x.Priority)
                     .Include(x => x.Lead).ThenInclude(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Where(predicate)).OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToListAsync();
                if (result != null && result.Count > 0)
                {
                    result.ForEach(x =>
                    {
                        //    x.Project = x.TaskOnId == 1 && x.LeadId != null ?
                        //DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                        x.Opportunity = x.TaskOnId == 2 && x.OpportunityId != null ?
                    DBContext.Crmopportunity.Where(y => y.Id == x.OpportunityId).FirstOrDefault() : new Crmopportunity();
                        x.Project = x.TaskOnId == 3 && x.ProjectId != null ?
                        DBContext.Project.Where(y => y.Id == x.ProjectId).FirstOrDefault() : new Project();
                    });
                }

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                if (page.StartIndex <= 1)
                {
                    var totalrecord = DBContext.Crmtask.Where(x => x.BranchId == page.BranchId && (x.TaskAssignedTo == page.UserId || page.UserId == 0)).Where(predicate);
                    TotalNumberOfRows.Value = totalrecord.Count();
                }
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmtask")]
        public async Task<IActionResult> InsertCrmtask([FromBody] Crmtask Crmtask)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmtaskId = new JProperty("Id", "");
            try
            {
                if (Crmtask.Id <= 0)
                {
                    var code = new CodeGenerator();
                    CodeGeneratorController generator = new CodeGeneratorController(DBContext);
                    var usercode = generator.Get(Crmtask.BranchId, _crmTaskNo);
                    var branch = (DBContext.Branch.Where(x => x.Id == Crmtask.BranchId).FirstOrDefault());
                    Crmtask.CaseId = branch.CrmLeadPrefix + string.Format("{0,10:d4}", usercode.LatestCode);
                    Crmtask.CaseId = Crmtask.CaseId.Replace(" ", "");
                }
                var newUser = DBContext.Crmtask.Update(Crmtask);
                DBContext.SaveChanges();
                return GetCrmtask(Crmtask.Id).Result;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmtaskId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmtask")]
        public async Task<IActionResult> UpdateCrmtask([FromBody] Crmtask Crmtask)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.Crmtask.Update(Crmtask);
                DBContext.SaveChanges();
                return GetCrmtask(Crmtask.Id).Result;

            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmtask")]
        public async Task<IActionResult> DeleteCrmtask([FromBody] Crmtask Crmtask)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                Crmtask.IsDeleted = 1;
                DBContext.Crmtask.Update(Crmtask);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmtaskDetail/{Id}")]
        public async Task<IActionResult> GetCrmtaskDetail(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskDetail
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmtaskDetail")]
        public async Task<IActionResult> GetAllCrmtaskDetail()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskDetail
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmtaskDetail")]
        public async Task<IActionResult> InsertCrmtaskDetail([FromBody] CrmtaskDetail CrmtaskDetail)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmtaskDetailId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmtaskDetail.Update(CrmtaskDetail);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmtaskDetailId.Value = newUser.Entity.Id;
                }
                else
                    CrmtaskDetailId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmtaskDetailId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmtaskDetail")]
        public async Task<IActionResult> UpdateCrmtaskDetail([FromBody] CrmtaskDetail CrmtaskDetail)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmtaskDetail.Update(CrmtaskDetail);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmtaskDetail")]
        public async Task<IActionResult> DeleteCrmtaskDetail([FromBody] CrmtaskDetail CrmtaskDetail)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmtaskDetail.IsDeleted = 1;
                DBContext.CrmtaskDetail.Update(CrmtaskDetail);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmtaskDocument/{Id}")]
        public async Task<IActionResult> GetCrmtaskDocument(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskDocument
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmtaskDocument")]
        public async Task<IActionResult> GetAllCrmtaskDocument()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskDocument
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmtaskDocument")]
        public async Task<IActionResult> InsertCrmtaskDocument([FromBody] CrmtaskDocument CrmtaskDocument)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmtaskDocumentId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmtaskDocument.Update(CrmtaskDocument);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmtaskDocumentId.Value = newUser.Entity.Id;
                }
                else
                    CrmtaskDocumentId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmtaskDocumentId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmtaskDocument")]
        public async Task<IActionResult> UpdateCrmtaskDocument([FromBody] CrmtaskDocument CrmtaskDocument)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmtaskDocument.Update(CrmtaskDocument);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmtaskDocument")]
        public async Task<IActionResult> DeleteCrmtaskDocument([FromBody] CrmtaskDocument CrmtaskDocument)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmtaskDocument.IsDeleted = 1;
                DBContext.CrmtaskDocument.Update(CrmtaskDocument);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpGet("GetCrmtaskType/{Id}")]
        public async Task<IActionResult> GetCrmtaskType(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskType
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmtaskType")]
        public async Task<IActionResult> GetAllCrmtaskType()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmtaskType
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmtaskType")]
        public async Task<IActionResult> InsertCrmtaskType([FromBody] CrmtaskType CrmtaskType)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmtaskTypeId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmtaskType.Update(CrmtaskType);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmtaskTypeId.Value = newUser.Entity.Id;
                }
                else
                    CrmtaskTypeId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmtaskTypeId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmtaskType")]
        public async Task<IActionResult> UpdateCrmtaskType([FromBody] CrmtaskType CrmtaskType)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmtaskType.Update(CrmtaskType);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmtaskType")]
        public async Task<IActionResult> DeleteCrmtaskType([FromBody] CrmtaskType CrmtaskType)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmtaskType.IsDeleted = 1;
                DBContext.CrmtaskType.Update(CrmtaskType);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #region CRMQuotationTerms

        [HttpGet("GetCrmCrmQuotationTerms/{Id}")]
        public async Task<IActionResult> GetCrmCrmQuotationTerms(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmquotationTerms
                    .Where(x => x.Id == Id && x.IsDeleted != 1)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpGet("GetAllCrmQuotationTerms")]
        public async Task<IActionResult> GetAllCrmQuotationTerms()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmquotationTerms
                    .Where(x => x.IsDeleted != 1)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("InsertCrmQuotationTerms")]
        public async Task<IActionResult> InsertCrmQuotationTerms([FromBody] CrmquotationTerms CrmQuotationTerms)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CrmQuotationTermsId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CrmquotationTerms.Update(CrmQuotationTerms);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CrmQuotationTermsId.Value = newUser.Entity.Id;
                }
                else
                    CrmQuotationTermsId.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CrmQuotationTermsId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmQuotationTerms")]
        public async Task<IActionResult> UpdateCrmQuotationTerms([FromBody] CrmquotationTerms CrmQuotationTerms)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmquotationTerms.Update(CrmQuotationTerms);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("DeleteCrmQuotationTerms")]
        public async Task<IActionResult> DeleteCrmQuotationTerms([FromBody] CrmquotationTerms CrmQuotationTerms)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CrmQuotationTerms.IsDeleted = 1;
                DBContext.CrmquotationTerms.Update(CrmQuotationTerms);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        [HttpGet("GetCrmCrmQuotationTermsByBranch/{BranchId}")]
        public async Task<IActionResult> GetCrmCrmQuotationTermsByBranch(long BranchId)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {

                var result = await (DBContext.CrmquotationTerms
                    .Where(x => x.IsDeleted != 1 && x.BranchId == BranchId)).OrderByDescending(x => x.Id).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }


        #endregion CRMQuotationTerms

        #region crm customer

        [HttpPost("GetAllCrmCustomerByPage")]
        public async Task<IActionResult> GetAllCrmCustomerByPage([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {

				#region filter
				var predicate = PredicateBuilder.New<User>(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.BranchId == page.BranchId
                    && (page.UserId == 0 || x.BasicDetail.CreatedBy == page.UserId));
				if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => (x.BasicDetail.Code != null && x.BasicDetail.Code.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.IncorporatedName != null && x.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.EmailId != null && x.BasicDetail.EmailId.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.Country != null && x.BasicDetail.Country.Name != null && x.BasicDetail.Country.Name.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.Emirates != null && x.BasicDetail.Emirates.Name != null && x.BasicDetail.Emirates.Name.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.Address != null && x.BasicDetail.Address.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.Trn != null && x.BasicDetail.Trn.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.SalesExecutive != null && x.BasicDetail.SalesExecutive.BasicDetail != null && x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName != null && x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower()))
                    || (x.BasicDetail.TelephoneNo != null && x.BasicDetail.TelephoneNo.ToLower().Contains(page.GlobalFilter.ToLower())))/* .ToList() */;
                }
                if (page.Filters != null)
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "BasicDetail.Code":
                                predicate = predicate.And(x => x.BasicDetail.Code != null && x.BasicDetail.Code.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.BasicDetail.IncorporatedName != null && x.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.EmailId":
                                predicate = predicate.And(x => x.BasicDetail.EmailId != null && x.BasicDetail.EmailId.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.Country.Name":
                                predicate = predicate.And(x => x.BasicDetail.Country != null && x.BasicDetail.Country.Name != null && x.BasicDetail.Country.Name.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.Emirates.Name":
                                predicate = predicate.And(x => x.BasicDetail.Emirates != null && x.BasicDetail.Emirates.Name != null && x.BasicDetail.Emirates.Name.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.Address":
                                predicate = predicate.And(x => x.BasicDetail.Address != null && x.BasicDetail.Address.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.Trn":
                                predicate = predicate.And(x => x.BasicDetail.Trn != null && x.BasicDetail.Trn.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.TelephoneNo":
                                predicate = predicate.And(x => x.BasicDetail.TelephoneNo != null && x.BasicDetail.TelephoneNo.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                            case "BasicDetail.SalesExecutive.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.BasicDetail.SalesExecutive != null && x.BasicDetail.SalesExecutive.BasicDetail != null && x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName != null && x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()))/* .ToList() */;
                                break;
                        }
                    }
                #endregion

                /* List<User> result;
                if ((page.GlobalFilter != null && page.GlobalFilter != "") || (page.Filters != null && page.Filters.Count > 0))
                { */
                    var result = await DBContext.User
												.Where(predicate)
												.OrderByDescending(x => x.Id)
												.Skip(page.StartIndex)
												.Take(page.NoOfRows)
												.Select(x => new {
													x.Id,
													x.UserName,
													x.Password,
													x.IsActive,
													x.UserRoleId,
													x.BasicDetailId,
													x.UserDetailsId,
													x.IsDeleted,
													x.UserRoleRuleId,
													BasicDetail = new {
														x.BasicDetail.Id,
														x.BasicDetail.Code,
														x.BasicDetail.CountryId,
														x.BasicDetail.EmailId,
														x.BasicDetail.MobileNo,
														x.BasicDetail.CurrencyId,
														x.BasicDetail.Trn,
														x.BasicDetail.FaxNumber,
														x.BasicDetail.EmiratesId,
														x.BasicDetail.BranchId,
														x.BasicDetail.Address,
														x.BasicDetail.LocationId,
														x.BasicDetail.CreatedBy,
														x.BasicDetail.Pobox,
														x.BasicDetail.TelephoneNo,
														x.BasicDetail.SponsorshipCompanyId,
														x.BasicDetail.IncorporatedName,
														x.BasicDetail.Website,
														x.BasicDetail.CreatedDate,
														x.BasicDetail.SalesExecutiveId,
														x.BasicDetail.OfficePhotoId,
														x.BasicDetail.OutsideViewPhotoId,
														x.BasicDetail.IsOwnLead,
														x.BasicDetail.MakaniNumber,
														x.BasicDetail.SalutationId,
                                                        x.BasicDetail.StatusId,
                                                        x.BasicDetail.Longitude,
                                                        x.BasicDetail.Latitude,
                                                        CommentId = x.BasicDetail.CommentId,
                                                        Comment = new  { 
                                                            x.BasicDetail.Comment.Id,
                                                            x.BasicDetail.Comment.Comment
                                                        },
														Country = new {
															x.BasicDetail.Country.Id,
															x.BasicDetail.Country.Name,
															x.BasicDetail.CurrencyId
														},
														Currency = new {
															x.BasicDetail.Currency.Id,
															x.BasicDetail.Currency.Name,
														},
														Emirates = new {
															x.BasicDetail.Emirates.Id,
															x.BasicDetail.Emirates.Name,
															x.BasicDetail.Emirates.CountryId,
															x.BasicDetail.Emirates.ExtensionCode,
														},
														Location = new {
															x.BasicDetail.Location.Id,
															x.BasicDetail.Location.Name,
														},
														SalesExecutive = new {
															x.BasicDetail.SalesExecutive.Id,
															x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName,
														},
													},
													UserRefrence = x.UserRefrence.Where(y => y.IsDeleted != 1).Select(y => new {
														y.Id,
														y.Name,
														y.ContactNo,
														y.Email,
														y.UserId,
														y.IsDeleted,
														y.DesignationId,
														Designation = new {
															y.Designation.Id,
															y.Designation.Name,
														},
                                                        y.SalutationId,
													}),
													SisterConcernCompanies = new {
														x.SisterConcernCompanies.Id,
														x.SisterConcernCompanies.CustomerId,
														x.SisterConcernCompanies.ParentId,
														x.SisterConcernCompanies.IsDeleted,
														Parent = new {
															x.SisterConcernCompanies.Parent.Id,
															x.SisterConcernCompanies.Parent.IsDeleted,
															InverseParent = x.SisterConcernCompanies
																			 .Parent
																			 .InverseParent
																			//  .Where(y => y.Id != x.Id)
																			 .Select(y => new {
																				 					y.CustomerId,
																									y.Customer.BasicDetail.IncorporatedName,
																							  }),
														},
													}
												})
												.ToListAsync();
                /* }
                else
                {
                    result = await DBContext.User.Include(x => x.BasicDetail).Include(x => x.BasicDetail.BloodGroup)
                    .Include(x => x.BasicDetail.Branch).Include(x => x.BasicDetail.Category).Include(x => x.BasicDetail.Country)
                    .Include(x => x.BasicDetail.Currency).Include(x => x.BasicDetail.Emirates).Include(x => x.BasicDetail.AdvanceAccount)
                    .Include(x => x.BasicDetail.Location).Include(x => x.BasicDetail.Photo).Include(x => x.BasicDetail.Account)
                    .Include(x => x.BasicDetail.Religion).Include(x => x.BasicDetail.SponsorshipCompany).Include(x => x.BasicDetail.State)
                    .Include(x => x.UserDetails).Include(x => x.UserDetails.DrivingLicenceType).Include(x => x.BasicDetail.PaymentSchedule)
                    .Include(x => x.UserDetails.Eidstatus).Include(x => x.UserDetails.PaymentMode)
                    .Include(x => x.UserDocument).ThenInclude(x => x.Attachment).Include(x => x.UserDocument).ThenInclude(x => x.DocumentType).Include(x => x.UserHistory)
                    .Include(x => x.UserRefrence).ThenInclude(x => x.Designation).Include(x => x.UserRole)
                    .Include(x => x.JobDetailsUser).ThenInclude(x => x.Grade)
					.Include(x => x.SisterConcernCompanies).ThenInclude(x => x.Parent).ThenInclude(x => x.InverseParent)
                    .Include(x => x.BasicDetail.SalesExecutive.BasicDetail)
                    .Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.BranchId == page.BranchId
                    && (page.UserId == 0 || x.BasicDetail.CreatedBy == page.UserId))
                    .OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows)
                    .ToListAsync();
                } */

                /* if (page.StartIndex <= 1)
                {
                    var totalrecord = 0;
                    if ((page.GlobalFilter != null && page.GlobalFilter != "") || (page.Filters != null && page.Filters.Count > 0))
                    {
                        totalrecord = result.Count();
                        TotalNumberOfRows.Value = totalrecord;
                    }
                    else
                    {
                        totalrecord = DBContext.User.Include(x => x.BasicDetail)
                        .Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.BranchId == page.BranchId && (page.UserId == 0 || x.BasicDetail.CreatedBy == page.UserId)).Count();
                        TotalNumberOfRows.Value = totalrecord;
                    }
                } */
				if (page.StartIndex <= 1)
				{
					TotalNumberOfRows.Value = DBContext.User.Where(predicate).Select(x => x.Id).Count();
				}

                /* if ((page.GlobalFilter != null && page.GlobalFilter != "") || (page.Filters != null && page.Filters.Count > 0))
                    result = result.OrderByDescending(x => x.Id).Skip(page.StartIndex).Take(page.NoOfRows).ToList(); */
                // ExcludeJson(result);
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                        });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(CrmCustomerDataObject);
        }
        [HttpGet("GetCrmCustomer/{Id}")]
        public async Task<IActionResult> GetCrmCustomer(long Id)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.User/* .Include(x => x.BasicDetail).Include(x => x.BasicDetail.BloodGroup)
                    .Include(x => x.BasicDetail.Branch).Include(x => x.BasicDetail.Category).Include(x => x.BasicDetail.Country)
                    .Include(x => x.BasicDetail.Currency).Include(x => x.BasicDetail.Emirates).Include(x => x.BasicDetail.AdvanceAccount)
                    .Include(x => x.BasicDetail.Location).Include(x => x.BasicDetail.Photo).Include(x => x.BasicDetail.Account)
                    .Include(x => x.BasicDetail.Religion).Include(x => x.BasicDetail.SponsorshipCompany).Include(x => x.BasicDetail.State)
                    .Include(x => x.UserDetails).Include(x => x.UserDetails.DrivingLicenceType).Include(x => x.BasicDetail.PaymentSchedule)
                    .Include(x => x.UserDetails.Eidstatus).Include(x => x.UserDetails.PaymentMode).Include(x => x.UserDocument).ThenInclude(x => x.DocumentType)
                    .Include(x => x.UserDocument).ThenInclude(x => x.Attachment).Include(x => x.UserHistory)
                    .Include(x => x.UserRefrence).ThenInclude(x => x.Designation).Include(x => x.UserRole)
                    .Include(x => x.JobDetailsUser).ThenInclude(x => x.Grade)
                    .Include(x => x.BasicDetail.SalesExecutive.BasicDetail) */
                    .Where(x => x.UserRoleId == _crmCustomerRoleId && x.Id == Id && x.IsDeleted != 1).Select(x => new {
													x.Id,
													x.UserName,
													x.Password,
													x.IsActive,
													x.UserRoleId,
													x.BasicDetailId,
													x.UserDetailsId,
													x.IsDeleted,
													x.UserRoleRuleId,
													BasicDetail = new {
														x.BasicDetail.Id,
														x.BasicDetail.Code,
														x.BasicDetail.CountryId,
														x.BasicDetail.EmailId,
														x.BasicDetail.MobileNo,
														x.BasicDetail.CurrencyId,
														x.BasicDetail.Trn,
														x.BasicDetail.FaxNumber,
														x.BasicDetail.EmiratesId,
														x.BasicDetail.BranchId,
														x.BasicDetail.Address,
														x.BasicDetail.LocationId,
														x.BasicDetail.CreatedBy,
														x.BasicDetail.Pobox,
														x.BasicDetail.TelephoneNo,
														x.BasicDetail.SponsorshipCompanyId,
														x.BasicDetail.IncorporatedName,
														x.BasicDetail.Website,
														x.BasicDetail.CreatedDate,
														x.BasicDetail.SalesExecutiveId,
														x.BasicDetail.OfficePhotoId,
														x.BasicDetail.OutsideViewPhotoId,
														x.BasicDetail.IsOwnLead,
														x.BasicDetail.MakaniNumber,
														x.BasicDetail.SalutationId,
														x.BasicDetail.StatusId,
														x.BasicDetail.Longitude,
														x.BasicDetail.Latitude,
														Country = new {
															x.BasicDetail.Country.Id,
															x.BasicDetail.Country.Name,
															x.BasicDetail.CurrencyId
														},
														Currency = new {
															x.BasicDetail.Currency.Id,
															x.BasicDetail.Currency.Name,
														},
														Emirates = new {
															x.BasicDetail.Emirates.Id,
															x.BasicDetail.Emirates.Name,
															x.BasicDetail.Emirates.CountryId,
															x.BasicDetail.Emirates.ExtensionCode,
														},
														Location = new {
															x.BasicDetail.Location.Id,
															x.BasicDetail.Location.Name,
														},
														SalesExecutive = new {
															x.BasicDetail.SalesExecutive.Id,
															x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName,
														},
													},
													UserRefrence = x.UserRefrence.Where(y => y.IsDeleted != 1).Select(y => new {
														y.Id,
														y.Name,
														y.ContactNo,
														y.Email,
														y.UserId,
														y.IsDeleted,
														y.DesignationId,
														Designation = new {
															y.Designation.Id,
															y.Designation.Name,
														},
                                                        y.SalutationId,
													}),
													SisterConcernCompanies = new {
														x.SisterConcernCompanies.Id,
														x.SisterConcernCompanies.CustomerId,
														x.SisterConcernCompanies.ParentId,
														x.SisterConcernCompanies.IsDeleted,
														Parent = new {
															x.SisterConcernCompanies.Parent.Id,
															x.SisterConcernCompanies.Parent.IsDeleted,
															InverseParent = x.SisterConcernCompanies
																			 .Parent
																			 .InverseParent
																			//  .Where(y => y.Id != x.Id)
																			 .Select(y => new {
																				 					y.CustomerId,
																									y.Customer.BasicDetail.IncorporatedName,
																							  }),
														},
													}
												}).ToListAsync());
                // ExcludeJson(result);
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }

        [HttpPost("UpdateCrmCustomer")]
        public async Task<IActionResult> UpdateCrmCustomer([FromBody] User user)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
				user = await setSisterConcernCompanies(user);
				if(user.UserRefrence.Count()>0){
					user.UserRefrence = await setLeadRefrence(user.UserRefrence);
				}
				var newUser = DBContext.User.Update(user);
                DBContext.SaveChanges();
                if (newUser.Entity.Id > 0)
                    return GetCrmCustomer(newUser.Entity.Id).Result;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }

        [HttpPost("DeleteCrmCustomer")]
        public async Task<IActionResult> DeleteCrmCustomer([FromBody] User user)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                user.IsDeleted = 1;
                user.SisterConcernCompanies.Parent = null;
                var newUser = DBContext.User.Update(user);
                DBContext.SaveChanges();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(newUser.Entity,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                        });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
                //   _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }
        [HttpPost("InsertCrmCustomer")]
        public async Task<IActionResult> InsertCrmCustomer([FromBody] User Val)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                if (Val.Id <= 0)
                {
                    var code = new CodeGenerator();
                    CodeGeneratorController generator = new CodeGeneratorController(DBContext);
                    var usercode = generator.Get(Val.BasicDetail.BranchId, _crmCustomerRoleId);
                    var branch = (DBContext.Branch.Where(x => x.Id == Val.BasicDetail.BranchId).FirstOrDefault());
                    Val.BasicDetail.Code = branch.CrmCustomerPrefix + string.Format("{0,10:d4}", usercode.LatestCode);
                    Val.BasicDetail.Code = Val.BasicDetail.Code.Replace(" ", "");
                    Val.BasicDetail.CreatedDate = DateTime.Now;
                }
				Val = await setSisterConcernCompanies(Val);
                var newUser = DBContext.User.Update(Val);
                DBContext.SaveChanges();
                if (newUser.Entity.Id > 0)
                    return GetCrmCustomer(newUser.Entity.Id).Result;
            }
            catch (Exception ex)
            {
                //  _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }
        
		async Task<User> setSisterConcernCompanies(User user){
			if(user.SisterConcernCompanies != null){
					var parentId = user.SisterConcernCompanies.ParentId;
					List<SisterConcernCompanies> updateEntries = new List<SisterConcernCompanies>{};
					List<SisterConcernCompanies> deleteEntries = new List<SisterConcernCompanies>{};
					var customerIds = user?.SisterConcernCompanies?.Parent?.InverseParent?.Select(x => x.CustomerId).ToList();
					var deletedCustomerIds = user?.SisterConcernCompanies?.Parent?.InverseParent?.Where(x => x.IsDeleted == 1).Select(x => x.CustomerId).ToList();
					var existingChildren = await DBContext.SisterConcernCompanies
															.Where(x => customerIds.Contains(x.CustomerId))
															.ToListAsync();
					var existingChildrenIds = existingChildren.Select(x => x.CustomerId);
					if(parentId == null){	
						if(existingChildren.Count() > 0)
						{
							parentId = existingChildren[0].ParentId;
						}
						else{
							var updatedEntry = DBContext.SisterConcernCompanies.Update(new SisterConcernCompanies{ IsDeleted = 0 });
							DBContext.SaveChanges();
							if(updatedEntry.Entity.Id >0){
								parentId = updatedEntry.Entity.Id;
							}
						}
					}
				SisterConcernCompanies parent = new SisterConcernCompanies { 
					Id = parentId.Value,
					IsDeleted = 0
				};
				var parents = existingChildren.Select(x => x.ParentId).Distinct().ToList();
				if(parents.Count() > 1 || !parents.Contains(parentId)){
					var otherParents = parents.Where(x => x != parentId).ToList();
					updateEntries = existingChildren.Where(x => x.ParentId != parentId).ToList();
					updateEntries.ForEach(x => { 
						x.ParentId = parentId; 
						x.Parent = parent; 
					});
					otherParents.ForEach(async (x) =>
					{
						var otherChilderen = await DBContext.SisterConcernCompanies
															.Where(y => !updateEntries.Select(z => z.CustomerId).Contains(y.CustomerId) 
																		&& y.ParentId == x)
															.Select(y => new SisterConcernCompanies {
																Id = y.Id,
																ParentId = parentId,
																CustomerId = y.CustomerId,
																IsDeleted = y.IsDeleted
															})
															.ToListAsync();
						updateEntries.AddRange(otherChilderen);
						deleteEntries.Add(new SisterConcernCompanies { 
							Id = x.Value, 
							IsDeleted = 1,
							InverseParent = new List<SisterConcernCompanies>{}
						 });
					});
				}
					if(deletedCustomerIds.Count() > 0){
						var delete = existingChildren.Where(x => deletedCustomerIds.Contains(x.CustomerId)).ToList();
						delete.ForEach(x => x.IsDeleted = 1);
						customerIds = customerIds.Where(x => !deletedCustomerIds.Contains(x)).ToList();
						deleteEntries.AddRange(delete);
					}
					var newEntries = customerIds.Where(customer => !existingChildrenIds.Contains(customer))
								.ToList()
								.Select(customer => 
									new SisterConcernCompanies
									{
										CustomerId = customer,
										ParentId = parentId
									});
				updateEntries.AddRange(newEntries);
				if(updateEntries.Count() > 0){
					DBContext.SisterConcernCompanies.UpdateRange(updateEntries);
					DBContext.SaveChanges();
				}
				if(deleteEntries.Count() > 0){
					DBContext.SisterConcernCompanies.RemoveRange(deleteEntries);
					DBContext.SaveChanges();
				}
				user.SisterConcernCompanies.ParentId = parentId;
				user.SisterConcernCompanies.Parent = null;
				}
			return user;
		}

		async Task<ICollection<UserRefrence>> setLeadRefrence(ICollection<UserRefrence> userRefrence){
			var changedUserReference = await DBContext.UserRefrence
											   .Where(x => userRefrence.Select(y => y.Id).Contains(x.Id))
											   .Select(x => new UserRefrence () {
												   Id = x.Id,
												   Name = x.Name,
												   ContactNo = x.ContactNo,
												   Email = x.Email,
												   UserId = x.UserId,
												   IsDeleted = x.IsDeleted,
												   DesignationId = x.DesignationId,
                                                   SalutationId = x.SalutationId,

                                                   Crmleadreference = x.Crmleadreference.Select(y => new CrmleadReference {
																										Id = y.Id,
																										Name = y.Name,
																										ContactNo = y.ContactNo,
																										Email = y.Email,
																										CrmleadId = y.CrmleadId,
																										IsDeleted = y.IsDeleted,
																										DesignationId = y.DesignationId,
																										DefaultContact = y.DefaultContact,
																										CustomerReferenceId = y.CustomerReferenceId,
																									} )
																						.ToList()
											   })
											   .ToListAsync();
			changedUserReference.ForEach(reference => {
				var modifiedValue = userRefrence.Where(x => x.Id == reference.Id).FirstOrDefault();
				if(modifiedValue != null)
				{
					reference.Name = modifiedValue.Name; 
					reference.ContactNo = modifiedValue.ContactNo; 
					reference.Email = modifiedValue.Email; 
					reference.IsDeleted = modifiedValue.IsDeleted; 
					reference.DesignationId = modifiedValue.DesignationId;
                    reference.SalutationId = modifiedValue.SalutationId;
					reference.Crmleadreference = reference.Crmleadreference.Select(y => new CrmleadReference {
																											Id = y.Id,
																											Name = reference.Name,
																											ContactNo = reference.ContactNo,
																											Email = reference.Email,
																											CrmleadId = y.CrmleadId,
																											IsDeleted = reference.IsDeleted,
																											DesignationId = reference.DesignationId,
																											DefaultContact = y.DefaultContact,
																											CustomerReferenceId = y.CustomerReferenceId,
																										} )
																			.ToList();
				}
			});
			changedUserReference.AddRange(userRefrence.Where(x => x.Id <= 0).ToList());
			return /* userRefrence */changedUserReference;
		}

		[HttpGet("GetAllCrmCustomerAutocomplete/{BranchId}")]
        public async Task<IActionResult> GetAllCrmCustomerAutocomplete(int BranchId)
        {
            var jsonObject = new JObject();
            dynamic commonDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.User.Include(x => x.BasicDetail)
                    .Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.BranchId == BranchId)
                    .Include(x => x.JobDetailsUser)
                     .ThenInclude(x => x.Designation)
                    .Include(x => x.UserRefrence).Include("UserRefrence.Designation")


                .Select(x => new
                {
                    Id = x.Id,
                    IncorporatedName = x.BasicDetail.IncorporatedName,
                    FirstName = x.BasicDetail.FirstName,
                    EmailId = x.BasicDetail.EmailId,
                    telephoneNo = x.BasicDetail.TelephoneNo,
                    Website = x.BasicDetail.Website,
                    PhoneNumber = x.BasicDetail.LocalCompanyMobileNo,
                    Designation = (x.JobDetailsUser != null && x.JobDetailsUser.Count > 0 && x.JobDetailsUser.FirstOrDefault().Designation != null) ?
                        x.JobDetailsUser.FirstOrDefault().Designation.Name : null,
                    SignatureId = x.BasicDetail.SignatureId,
                    UserReference = x.UserRefrence,
                    x.BasicDetail.EmiratesId,
                    x.BasicDetail.LocationId,
                    x.BasicDetail.SalesExecutiveId,
					SalesExecutiveName = x.BasicDetail.SalesExecutiveId != null ? $"{x.BasicDetail.SalesExecutive.BasicDetail.Code}  {x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName}" : ""
                }).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

                commonDataObject.Results = new JArray() as dynamic;
                commonDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(commonDataObject);
        }

		[HttpGet("GetAllCrmSisterConcernCustomerAutocomplete/{BranchId}")]
        public async Task<IActionResult> GetAllCrmSisterConcernCustomerAutocomplete(int BranchId)
		{
			var jsonObject = new JObject();
            dynamic commonDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
			try
			{
				var result = await DBContext.User
											.Where(x => x.UserRoleId == _crmCustomerRoleId
														&& x.IsDeleted != 1
														&& x.BasicDetail.BranchId == BranchId)
											.Select(x => new {
												CustomerId = x.Id,
												x.BasicDetail.IncorporatedName,
												x.BasicDetail.EmailId,
												x.BasicDetail.StatusId
											 })
											.ToListAsync();
				var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

                commonDataObject.Results = new JArray() as dynamic;
                commonDataObject.Results.Add(jsonResult);
			}
			catch (Exception ex) 
			{
				 sucess.Value = ""; error.Value = ex.Message; 
			}
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(commonDataObject);
		}


        #endregion

        #region Common method
        public void ExcludeJson(List<User> result)
        {
            if (result != null && result.Count > 0)
            {
                result.ForEach(model =>
                {
                    model.BasicDetails = null;
                    if (model.JobDetailsUser != null && model.JobDetailsUser.Count > 0)
                    {
                        if (model.JobDetailsUser.FirstOrDefault().Grade != null)
                        {
                            model.JobDetailsUser.FirstOrDefault().Grade.Role = null;
                            model.JobDetailsUser.FirstOrDefault().Grade.JobDetails = null;
                        }
                        if (model.JobDetailsUser.FirstOrDefault().WorkLocation != null)
                        {
                            model.JobDetailsUser.FirstOrDefault().WorkLocation.JobDetails = null;
                        }
                    }
                    if (model.BasicDetail != null && model.BasicDetail.AdvanceAccount != null)
                    {
                        model.BasicDetail.AdvanceAccount.BasicDetailsAdvanceAccount = null;
                        model.BasicDetail.AdvanceAccount.BasicDetailsAccount = null;
                    }
                    if (model.BasicDetail != null && model.BasicDetail.Account != null)
                    {
                        model.BasicDetail.Account.BasicDetailsAdvanceAccount = null;
                        model.BasicDetail.Account.BasicDetailsAccount = null;
                    }
                    if (model.UserRole != null)
                    {
                        model.UserRole.User = null;
                        model.UserRole.GradeType = null;
                        model.UserRole.RateContractTemplete = null;
                        model.UserRole.UserCategory = null;
                    }
                    if (model.BasicDetail != null && model.BasicDetail.Country != null && model.BasicDetail.Country.Currency != null)
                    {
                        model.BasicDetail.Country.Currency.Country = null;
                        model.BasicDetail.Country.Currency.SponsorshipCompany = null;
                        model.BasicDetail.Country.Currency.BasicDetails = null;
                        model.BasicDetail.Country.Currency.Branch = null;
                    }
                    if (model.BasicDetail != null && model.BasicDetail.Country != null)
                    {
                        model.BasicDetail.Country.SponsorshipCompany = null;
                        model.BasicDetail.Country.BasicDetails = null;
                        model.BasicDetail.Country.Emirate = null;
                        model.BasicDetail.Country.Branch = null;
                        model.BasicDetail.Country.State = null;
                    }
                    if (model.BasicDetail != null)
                    {
                        model.BasicDetail.User = null;
                        model.BasicDetail.Supplier = null;
                        if (model.BasicDetail.Emirates != null)
                        {
                            model.BasicDetail.Emirates.BasicDetails = null;
                            model.BasicDetail.Emirates.ProjectDetails = null;
                            model.BasicDetail.Emirates.Country = null;
                        }
                        if (model.BasicDetail.PaymentSchedule != null)
                        {
                            model.BasicDetail.PaymentSchedule.BasicDetails = null;
                            model.BasicDetail.PaymentSchedule.Project = null;
                        }
                        if (model.BasicDetail.Currency != null)
                        {
                            model.BasicDetail.Currency.Country = null;
                            model.BasicDetail.Currency.SponsorshipCompany = null;
                            model.BasicDetail.Currency.Branch = null;
                            model.BasicDetail.Currency.BasicDetails = null;
                        }
                        if (model.BasicDetail.SponsorshipCompany != null)
                        {
                            model.BasicDetail.SponsorshipCompany.County = null;
                            model.BasicDetail.SponsorshipCompany.Currency = null;
                            model.BasicDetail.SponsorshipCompany.Branch = null;
                            model.BasicDetail.SponsorshipCompany.BasicDetails = null;
                            model.BasicDetail.SponsorshipCompany.UserDocument = null;
                        }
                        if (model.BasicDetail.Branch != null)
                        {
                            model.BasicDetail.Branch = null;
                            //model.BasicDetail.Branch.CodeGenerator = null;
                        }
                        if (model.BasicDetail.Category != null)
                            model.BasicDetail.Category.BasicDetails = null;
                        if (model.BasicDetail.Location != null)
                        {
                            model.BasicDetail.Location.BasicDetails = null;
                            model.BasicDetail.Location.ProjectDetails = null;
                            model.BasicDetail.Location.ProjectLocation = null;
                        }
						/* if(model.BasicDetail.SisterConcernCompany != null){
							model.BasicDetail.SisterConcernCompany.UserRole = null;
							model.BasicDetail.SisterConcernCompany.JobDetailsUser = null;
							model.BasicDetail.SisterConcernCompany.UserRefrence = null;
							if(model.BasicDetail.SisterConcernCompany.BasicDetail != null){
								model.BasicDetail.SisterConcernCompany.BasicDetail.Country = null;
								model.BasicDetail.SisterConcernCompany.BasicDetail.Currency = null;
								model.BasicDetail.SisterConcernCompany.BasicDetail.Emirates = null;
								model.BasicDetail.SisterConcernCompany.BasicDetail.SponsorshipCompany = null;
								model.BasicDetail.SisterConcernCompany.BasicDetail.SalesExecutive = null;
							}
						} */
                    }
                    if (model.UserRefrence != null)
                    {
                        model.UserRefrence.ToList().ForEach(refs =>
                        {
                            if (refs.Designation != null)
                            {
                                refs.Designation.UserRefrence = null;
                                refs.Designation.JobDetails = null;
                                refs.Designation.KnownTrade = null;
                                refs.Designation.ProjectRate = null;
                                refs.Designation.RateContractTempleteTrades = null;
                                refs.Designation.UserRate = null;
                                refs.Designation.UserDetails = null;
                            }
                        });
                    }
                    if (model.UserDocument != null)
                    {
                        model.UserDocument.ToList().ForEach(doc =>
                        {
                            doc.User = null;
                            if (doc.DocumentType != null)
                            {
                                doc.DocumentType.UserDocument = null;
                                doc.DocumentType.ProjectDocument = null;
                            }
                        });
                    }
                    if (model.UserRate != null && model.UserRate.Count > 0)
                    {
                        model.UserRate.ToList().ForEach(rat =>
                        {
                            rat.User = null;
                            if (rat.Designation != null)
                            {
                                rat.Designation.JobDetails = null;
                                rat.Designation.KnownTrade = null;
                                rat.Designation.ProjectDetails = null;
                                rat.Designation.ProjectRate = null;
                                rat.Designation.RateContractTempleteTrades = null;
                                rat.Designation.UserDetails = null;
                                rat.Designation.UserRate = null;
                            }
                            if (rat.Occurance != null)
                            {
                                rat.Occurance.ProjectRate = null;
                                rat.Occurance.RateContractTempleteTrades = null;
                                rat.Occurance.UserRate = null;
                            }
                            if (rat.RateType != null)
                            {
                                rat.RateType.RateContractTempleteTrades = null;
                                rat.RateType.ProjectRate = null;
                                rat.RateType.UserRate = null;
                            }
                        });
                    }
                    if (model.UserHistory != null && model.UserHistory.Count > 0)
                    {
                        model.UserHistory.ToList().ForEach(x =>
                        {
                            x.User = null;
                        });
                    }
                });
            }
        }

        #endregion

        #region Send mail

        [HttpPost("CrmSendMail/{BranchId}")]
        public async Task<IActionResult> CrmSendMail(long BranchId, [FromBody] CrmleadReference[] crmleadReference)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                string WorldstarEmailUserName="";
                string WorldstarEmailPassword="";
                string mailresult = "";
                List<CrmleadReference> sentMail = new List<CrmleadReference>();
                List<CrmleadReference> notSentMail = new List<CrmleadReference>();
                if(BranchId==1)
                {
                    WorldstarEmailUserName = this.Settings.WorldstarSharjaEmailUserName;
                    WorldstarEmailPassword = this.Settings.WorldstarSharjaEmailPassword;
                } 
                else if(BranchId==2)
                {
                    WorldstarEmailUserName = this.Settings.WorldstarDXBEmailUserName;
                    WorldstarEmailPassword = this.Settings.WorldstarDXBEmailPassword;
                }
                else
                {
                    WorldstarEmailUserName = this.Settings.WorldstarAUHEmailUserName;
                    WorldstarEmailPassword = this.Settings.WorldstarAUHEmailPassword;
                }

                if (this.Settings.EmailServerName != null && WorldstarEmailPassword != null && WorldstarEmailUserName != null)
                {
                    if (crmleadReference != null && crmleadReference.Length > 0)
                    {
                        foreach (CrmleadReference reference in crmleadReference)
                        {
                            var result = new EmailService().OfficeSMTPMail(reference, "CRM Invitation", this._environment.ContentRootPath, WorldstarEmailUserName, WorldstarEmailPassword, this.Settings.EmailServerName, BranchId);
                            if (result == "Success")
                            {
                                sentMail.Add(reference);
                            }
                            else
                            {
                                notSentMail.Add(reference);
                            }
                        }
                    }
                }
                else
                {
                    error.Value = "Email not enabled, please check with System Team";
                    sucess.Value = "";
                }

                var jsonSentResult = Newtonsoft.Json.JsonConvert.SerializeObject(sentMail, Formatting.None,
                            new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                            });
                CrmCustomerDataObject.SentMail = new JArray() as dynamic;
                CrmCustomerDataObject.SentMail.Add(jsonSentResult);

                var jsonNotSentResult = Newtonsoft.Json.JsonConvert.SerializeObject(notSentMail, Formatting.None,
                           new JsonSerializerSettings()
                           {
                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                           });
                CrmCustomerDataObject.NotSentMail = new JArray() as dynamic;
                CrmCustomerDataObject.NotSentMail.Add(jsonNotSentResult);
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }

        #endregion

        #region Send SMS
        //[HttpPost("CrmSendSMS/{BranchId}")]
        //public async Task<IActionResult> CrmSendSMS(long BranchId, [FromBody] CrmleadReference[] crmleadReference)
        //{
        //    var jsonObject = new JObject();
        //    dynamic CrmCustomerDataObject = jsonObject;
        //    JProperty error = new JProperty("ErrorMessage", "");
        //    JProperty sucess = new JProperty("SuccessMessage", "Sucess");
        //    try
        //    {
        //        string smsResult = "";
        //        JObject result = new JObject();
        //        if (crmleadReference != null && crmleadReference.Length > 0)
        //        {
        //            //string WorldstarSMSAPI = "https://restapi.tobeprecisesms.com/";
        //            //string WorldstarSMSUserName = "Worldstar";
        //            //string WorldstarSMSUserPassword = "WSH98044";
        //            //string WorldstarSMSSenderName = "AD-WORLDSTR";

        //            if (this.Settings.WorldstarSMSAPI != null && this.Settings.WorldstarSMSAPI != "" && this.Settings.WorldstarSMSUserName != null && this.Settings.WorldstarSMSUserName != "" &&
        //                this.Settings.WorldstarSMSUserPassword != null && this.Settings.WorldstarSMSUserPassword != "" && this.Settings.WorldstarSMSSenderName != null && this.Settings.WorldstarSMSSenderName != "")
        //            {

        //                //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(this.Settings.WorldstarSMSUserName + ":" + this.Settings.WorldstarSMSUserPassword);

        //                var SmsRequest = new SMSRequest();
        //                SmsRequest.MobileNumbers = crmleadReference.Select(x => x.ContactNo).ToList();
        //                if(BranchId== 1)
        //                {
        //                    SmsRequest.Message = " Dear Mr. , \n We at World Star Manpower Supply would like to thankyou for choosing us for our services.\n We look forward to a continued relationship with your company overtime and I am looking forward to schedule a meeting with you regarding manpower supply. \n We always assure our prompt services.\n We appreciate your interest in our services.";
        //                }
        //                else if (BranchId == 2)
        //                {
        //                    SmsRequest.Message = "We supply Civil, MEP and other category of labors with expertise in manpower supply services. \n Contact us \n T - +971 43 466687 / 88 \n M - +971 56 546 7459 \n E - sales@marmoommanpower.com \n W - www.marmoommanpower.com ";
        //                }
        //                else if (BranchId == 3)
        //                {
        //                    SmsRequest.Message = "1) Thank you for Contacting Us \n Really happy to serve you for your manpower requirements, our dedicated professional will revert soon.\n Feel free to contact through our email to - inquiry@worldstarmanpower.ae \n Have a Great Day! \n 2) Thank you for Contacting Us \n Thanks for the opportunity to serve your manpower needs, it’s our privilege to provide the high - end manpower services for your organization, one of our professionals will get back you soon \n Send your queries through our email to - inquiry@worldstarmanpower.ae \n Have a Great Day! ";
        //                }
        //                SmsRequest.SenderName = this.Settings.WorldstarSMSSenderName;
        //                SmsRequest.RemoveDuplicates = true;
        //                SmsRequest.ReturnIndividualResponse = true;
        //                SmsRequest.AsynchronousSubmission = false;
        //                //SmsRequest.Authorization = System.Convert.ToBase64String(plainTextBytes);

        //                string jsonString = System.Text.Json.JsonSerializer.Serialize(SmsRequest);
        //                HttpContent value = new StringContent(jsonString, Encoding.UTF8, "application/json");
        //                using (var httpClient = new HttpClient())
        //                {
        //                    using (var response = await httpClient.PostAsync(this.Settings.WorldstarSMSAPI + "api/SendSMS/BulkSMS/?Username=" + this.Settings.WorldstarSMSUserName + "&Password=" + this.Settings.WorldstarSMSUserPassword, value))
        //                    {
        //                        string apiResponse = await response.Content.ReadAsStringAsync();
        //                        result = JObject.Parse(apiResponse);
        //                    }
        //                }
        //                error.Value = "";
        //                sucess.Value = "Sucess";
        //            }
        //            else
        //            {
        //                error.Value = "SMS not enabled, please check with System Team";
        //                sucess.Value = "";
        //            }
        //        }
        //        var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
        //                    new JsonSerializerSettings()
        //                    {
        //                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        //                    });
        //        CrmCustomerDataObject.Results = new JArray() as dynamic;
        //        CrmCustomerDataObject.Results.Add(jsonResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        // _logger.LogError(ex, ex.Message);
        //        if (ex.InnerException != null && ex.InnerException.Message != null)
        //            error.Value = ex.InnerException.Message;
        //        else
        //            error.Value = ex.Message;
        //        sucess.Value = "";
        //    }
        //    jsonObject.Add(error);
        //    jsonObject.Add(sucess);
        //    return Ok(CrmCustomerDataObject);
        //}


        [HttpPost("CrmSendSMS/{BranchId}")]
        public async Task<IActionResult> CrmSendSMS(long BranchId, [FromBody] CrmleadReference[] crmleadReference)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                string smsResult = "";
                JObject result = new JObject();
                if (crmleadReference != null && crmleadReference.Length > 0)
                {
                    string WorldstarSMSAPI = "";
                    string WorldstarSMSUserName = "";
                    string WorldstarSMSUserPassword = "";
                    string WorldstarSMSSenderName = "";
                    if (BranchId == 2)
                    {
                        WorldstarSMSAPI = this.Settings.WorldstarSMSAPI;
                        WorldstarSMSUserName = this.Settings.WorldstarDXBSMSUserName;
                        WorldstarSMSUserPassword = this.Settings.WorldstarDXBSMSUserPassword;
                        WorldstarSMSSenderName = this.Settings.WorldstarDXBSMSSenderName;
                    }
                    else
                    {
                        WorldstarSMSAPI = this.Settings.WorldstarSMSAPI;
                        WorldstarSMSUserName = this.Settings.WorldstarSMSUserName;
                        WorldstarSMSUserPassword = this.Settings.WorldstarSMSUserPassword;
                        WorldstarSMSSenderName = this.Settings.WorldstarSMSSenderName;
                    }
                    if (WorldstarSMSAPI != null && WorldstarSMSAPI != "" && WorldstarSMSUserName != null && WorldstarSMSUserName != "" &&
                        WorldstarSMSUserPassword != null && WorldstarSMSUserPassword != "" && WorldstarSMSSenderName != null && WorldstarSMSSenderName != "")
                    {

                        //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(this.Settings.WorldstarSMSUserName + ":" + this.Settings.WorldstarSMSUserPassword);
                        var SmsRequest = new SMSRequest();

                        if (BranchId == 1)
                        {
                            SmsRequest.MessageDetails = new List<MessageDetails>();
                            foreach (CrmleadReference reference in crmleadReference)
                            {

                                SmsRequest.MessageDetails.Add(new MessageDetails()
                                {

                                    To = reference.ContactNo,
                                    Message = " Dear " + reference.Name + ", \n We at World Star Manpower Supply would like to thankyou for choosing us for our services.\n We look forward to a continued relationship with your company overtime and I am looking forward to schedule a meeting with you regarding manpower supply. \n We always assure our prompt services.\n We appreciate your interest in our services."
                                });
                                // SmsRequest.Message = " Dear Mr. , \n We at World Star Manpower Supply would like to thankyou for choosing us for our services.\n We look forward to a continued relationship with your company overtime and I am looking forward to schedule a meeting with you regarding manpower supply. \n We always assure our prompt services.\n We appreciate your interest in our services.";

                            }
                        }
                        else
                        {

                            SmsRequest.MobileNumbers = crmleadReference.Select(x => x.ContactNo).ToList();

                            if (BranchId == 2)
                            {
                                SmsRequest.Message = "We supply Civil, MEP and other category of labors with expertise in manpower supply services. \n Contact us \n T - +971 43 466687 / 88 \n M - +971 56 546 7459 \n E - sales@marmoommanpower.com \n W - www.marmoommanpower.com ";
                            }
                            else if (BranchId == 3)
                            {
                                SmsRequest.Message = "Thank you for Contacting Us \n Thanks for the opportunity to serve your manpower needs, it’s our privilege to provide the high - end manpower services for your organization, one of our professionals will get back you soon \n Send your queries through our email to - inquiry@worldstarmanpower.ae \n Have a Great Day! ";

                            }

                        }
                        SmsRequest.SenderName = WorldstarSMSSenderName;
                        SmsRequest.RemoveDuplicates = true;
                        SmsRequest.ReturnIndividualResponse = true;
                        SmsRequest.AsynchronousSubmission = false;

                        //SmsRequest.Authorization = System.Convert.ToBase64String(plainTextBytes);
                        string SMSApi = BranchId == 1 ? "api/SendSMS/CustomSMS/" : "api/SendSMS/BulkSMS/";
                        string jsonString = System.Text.Json.JsonSerializer.Serialize(SmsRequest);
                        HttpContent value = new StringContent(jsonString, Encoding.UTF8, "application/json");
                        using (var httpClient = new HttpClient())
                        {
                            using (var response = await httpClient.PostAsync(WorldstarSMSAPI + SMSApi+"?Username=" + WorldstarSMSUserName + "&Password=" + WorldstarSMSUserPassword, value))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                result = JObject.Parse(apiResponse);
                            }
                        }
                        error.Value = "";
                        sucess.Value = "Sucess";
                    }
                    else
                    {
                        error.Value = "SMS not enabled, please check with System Team";
                        sucess.Value = "";
                    }
                }
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                            new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                            });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);
            }
             catch (Exception ex)
            {
                // _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(CrmCustomerDataObject);
        }

        #endregion

        #region Crm Reports

        [HttpGet("GetProjectAnalysisReport/{opportunityId}")]
        public async Task<IActionResult> GetProjectAnalysisReport(long opportunityId)
        {
            var jsonObject = new JObject();
            dynamic crmProjectObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity.Where(x => x.Id == opportunityId)
                    .Include(x => x.CrmopportunityDetail)
                    .Include(x => x.Lead)
                    .Include("Lead.CrmleadReference")
                    .Include("Lead.CompanyLocation")
                    .Include("Lead.ProjectLocation")
                    .Include("Lead.CompanyType")
                    .Include("Lead.Client.BasicDetail")
                    .Include("Lead.CrmleadDetails")
                 .ToListAsync();
                var populatedResult = listOfData.Select(x => new ProjectAnalysisReportViewModel
                {
                    Date = x.Date,
                    IsSelf = true,
                    CompanyName = x.Lead.CompanyName,
                    CompanyLocationX = x.Lead.CompanyLocation.Latitude,
                    CompanyLocationY = x.Lead.CompanyLocation.Longitude,
                    ProjectName = x.Lead.ProjectName,
                    ProjectLocationX = x.Lead.ProjectLocation.Latitude,
                    ProjectLocationY = x.Lead.ProjectLocation.Longitude,
                    ProjectType = x.Lead.CompanyType.Type,
                    ClientName = x.Lead.Client.BasicDetail.IncorporatedName,
                    PaymentTerms = "nil",
                    GuaranteeCheque = "nil",
                    ProjectDuration = "nil",
                    HoursPerDay = "nil",
                    FridayOrHolidaysWorkingStatus = "nil",
                    ContactDetails = x.Lead.CrmleadReference.ToList(),
                    ManpowerDetails = x.Lead.CrmleadDetails.ToList(),
                    Attachments = new List<long>(),
                    Remarks = "nil",
                    SalesExecutive = "nil",
                    ProcurementOperationsManager = "nil",
                    ExecutiveManager = "nil"
                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmProjectObject.Results = new JArray() as dynamic;
                crmProjectObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmProjectObject);
        }
        [HttpPost("GetDailyReportSalesman")]
        public async Task<IActionResult> GetDailyReportSalesman(RequestHeader request)
        {
            var jsonObject = new JObject();
            dynamic crmDailyReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            crmDailyReportObject.Values = new JArray() as dynamic;
            try
            {
                //var startDate = new DateTime(year, monthId, 1);
                //var endDate = startDate.AddMonths(1).AddDays(-1);

                var crmCustomerList = await DBContext.Crmlead.Where(x => x.IsDeleted != 1 && x.Date.HasValue && x.Date.Value.Date >= request.FromDate.Date && x.Date.Value.Date <= request.ToDate.Date && x.AssignedSalesExecutiveId == request.UserId)
                                    .Select(x => new CRMDailySalesManReportViewModel
                                    {
                                        Id = x.Id,
                                        Date = x.Date,
                                        CompanyName = x.Client != null && x.Client.BasicDetail != null ? x.Client.BasicDetail.IncorporatedName : "",
                                        ProjectName = x.ProjectName,
                                        LocationName = x.ProjectLocation != null ? x.ProjectLocation.Name : "",
                                        ContactPersonName = x.CrmleadReference.FirstOrDefault() != null ? x.CrmleadReference.FirstOrDefault().Name : "",
                                        Status = x.LeadStatus != null ? x.LeadStatus.Status : "",
                                        TaskTypeId = 0,
                                        TaskTypeName = "New Company"
                                    }).OrderByDescending(x => x.Date).ToListAsync();
                var custObj = Newtonsoft.Json.JsonConvert.SerializeObject(crmCustomerList,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                       });
                crmDailyReportObject.Values.Add(custObj);
                var crmTaskList = await DBContext.Crmtask.Where(x => x.IsDeleted != 1 && x.TaskCreatedDate.HasValue && x.TaskCreatedDate.Value.Date >= request.FromDate.Date && x.TaskCreatedDate.Value.Date <= request.ToDate.Date && x.TaskAssignedTo == request.UserId)
                                  .Select(x => new CRMDailySalesManReportViewModel
                                  {
                                      Id = x.Id,
                                      Date = x.TaskCreatedDate,
                                      CompanyName = x.TaskOnId == 1 ? (x.Lead != null && x.Lead.Client != null && x.Lead.Client.BasicDetail != null ? x.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                   (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null && x.Opportunity.Lead.Client != null && x.Opportunity.Lead.Client.BasicDetail != null ? x.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                   (x.Project != null && x.Project.Client != null && x.Project.Client.BasicDetail != null ? x.Project.Client.BasicDetail.IncorporatedName : "")),
                                      ProjectName = x.TaskOnId == 1 ? (x.Lead != null ? x.Lead.ProjectName : "") :
                                                   (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null ? x.Opportunity.Lead.ProjectName : "") :
                                                   (x.Project != null ? x.Project.ProjectName : "")),
                                      LocationName = x.TaskOnId == 1 ? (x.Lead != null && x.Lead.ProjectLocation != null ? x.Lead.ProjectLocation.Name : "") :
                                                    (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null && x.Opportunity.Lead.ProjectLocation != null ? x.Opportunity.Lead.ProjectLocation.Name : "")
                                                    : ""),
                                      ContactPersonName = x.TaskAssignedToNavigation != null && x.TaskAssignedToNavigation.BasicDetail != null ? x.TaskAssignedToNavigation.BasicDetail.IncorporatedName : "",
                                      Status = x.Status != null ? x.Status.Status : "",
                                      TaskTypeId = x.TaskTypeId,
                                      TaskTypeName = x.TaskType != null ? x.TaskType.Type : "",
                                  }).OrderByDescending(x => x.Date).ToListAsync();

                var groupedcrmTaskList = crmTaskList.GroupBy(x => x.TaskTypeId).ToList();
                foreach (var gct in groupedcrmTaskList)
                {
                    var gctObj = Newtonsoft.Json.JsonConvert.SerializeObject(gct,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                       });
                    crmDailyReportObject.Values.Add(gctObj);
                }

                var crmOpportunityList = await DBContext.Crmopportunity.Where(x => x.IsDeleted != 1 && x.Date.HasValue && x.Date.Value.Date >= request.FromDate.Date && x.Date.Value.Date <= request.ToDate.Date && x.Lead.AssignedSalesExecutiveId == request.UserId)
                                .Select(x => new CRMDailySalesManReportViewModel
                                {
                                    Id = x.Id,
                                    Date = x.Date,
                                    CompanyName = x.Lead != null && x.Lead.Client != null && x.Lead.Client.BasicDetail != null ? x.Lead.Client.BasicDetail.IncorporatedName : "",
                                    ProjectName = x.Lead != null ? x.Lead.ProjectName : "",
                                    LocationName = x.Lead != null && x.Lead.ProjectLocation != null ? x.Lead.ProjectLocation.Name : "",
                                    ContactPersonName = x.Lead != null && x.Lead.CrmleadReference != null && x.Lead.CrmleadReference.FirstOrDefault() != null ? x.Lead.CrmleadReference.FirstOrDefault().Name : "",
                                    Status = x.Status != null ? x.Status.Status : "",
                                    TaskTypeId = -1,
                                    TaskTypeName = "Quotation"
                                }).OrderByDescending(x => x.Date).ToListAsync();
                var opoObj = Newtonsoft.Json.JsonConvert.SerializeObject(crmOpportunityList,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                       });
                crmDailyReportObject.Values.Add(opoObj);
                var crmCustomerListResult = Newtonsoft.Json.JsonConvert.SerializeObject(crmCustomerList,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmDailyReportObject.CrmCustomerList = new JArray() as dynamic;
                crmDailyReportObject.CrmCustomerList.Add(crmCustomerListResult);

                var crmTaskListResult = Newtonsoft.Json.JsonConvert.SerializeObject(crmTaskList,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmDailyReportObject.CrmTaskList = new JArray() as dynamic;
                crmDailyReportObject.CrmTaskList.Add(crmTaskListResult);

                var crmOpportunityListResult = Newtonsoft.Json.JsonConvert.SerializeObject(crmOpportunityList,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmDailyReportObject.CrmOpportunityList = new JArray() as dynamic;
                crmDailyReportObject.CrmOpportunityList.Add(crmOpportunityListResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmDailyReportObject);
        }

        [HttpPost("GetSalesmanReport")]
        public async Task<IActionResult> GetSalesmanReport(RequestHeader request)
        {
            var jsonObject = new JObject();
            dynamic crmSalesmanReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            crmSalesmanReportObject.OpportunityResult = new JArray() as dynamic;
            try
            {
                //startDate = new DateTime(startDate);
                //endDate = new DateTime(endDate);

                var crmCustomerList = await DBContext.User.Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.CreatedBy == request.UserId && x.BasicDetail.CreatedDate.Value.Date >= request.FromDate.Date && x.BasicDetail.CreatedDate.Value.Date <= request.ToDate.Date)
                                   .Select(x => new
                                   {
                                       Id = x.Id,
                                       Date = x.BasicDetail != null ? x.BasicDetail.CreatedDate : null,
                                       Account = x.BasicDetail != null ? x.BasicDetail.IncorporatedName : "",
                                       Telephone = x.BasicDetail != null ? x.BasicDetail.TelephoneNo : "",
                                       Email = x.BasicDetail != null ? x.BasicDetail.EmailId : "",
                                       TypeId = 0,
                                       TypeName = "Account"
                                   }).OrderByDescending(x => x.Date).ToListAsync();
                var crmCustomerListResult = Newtonsoft.Json.JsonConvert.SerializeObject(crmCustomerList,
                                      new JsonSerializerSettings()
                                      {
                                          ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                      });
                crmSalesmanReportObject.CrmCustomerList = new JArray() as dynamic;
                crmSalesmanReportObject.CrmCustomerList.Add(crmCustomerListResult);

                var crmContactList = await DBContext.UserRefrence.Where(x => x.User.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.User.BasicDetail.CreatedBy == request.UserId && x.User.IsDeleted != 1 && x.User.BasicDetail.CreatedDate.Value.Date >= request.FromDate.Date && x.User.BasicDetail.CreatedDate.Value.Date <= request.ToDate.Date)
                                  .Select(x => new
                                  {
                                      Id = x.Id,
                                      ContactName = x.Name,
                                      Designation = x.Designation != null ? x.Designation.Name : "",
                                      AccountName = x.User != null && x.User.BasicDetail != null ? x.User.BasicDetail.IncorporatedName : "",
                                      Mobile = x.ContactNo,
                                      TypeId = 1,
                                      TypeName = "Contact"
                                  }).OrderBy(x => x.AccountName).ToListAsync();

                var crmUserReferenceListResult = Newtonsoft.Json.JsonConvert.SerializeObject(crmContactList,
                                      new JsonSerializerSettings()
                                      {
                                          ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                      });
                crmSalesmanReportObject.CrmUserReferenceList = new JArray() as dynamic;
                crmSalesmanReportObject.CrmUserReferenceList.Add(crmUserReferenceListResult);

                var crmOpportunityList = await DBContext.Crmopportunity.Where(x => x.IsDeleted != 1 && x.Date.HasValue && x.Date.Value.Date >= request.FromDate.Date && x.Date.Value.Date <= request.ToDate.Date && x.Lead.AssignedSalesExecutiveId == request.UserId)
                               .Select(x => new
                               {
                                   Id = x.Id,
                                   Number = x.OpportunityNumber,
                                   Name = x.OpportunityName,
                                   Account = x.Lead != null && x.Lead.Client != null && x.Lead.Client.BasicDetail != null ? x.Lead.Client.BasicDetail.IncorporatedName : "",
                                   Date = x.Date,
                                   TypeId = x.StatusId,
                                   TypeName = x.Status != null ? x.Status.Status : ""
                               }).OrderByDescending(x => x.Date).ToListAsync();

                var groupedcrmOppoList = crmOpportunityList.GroupBy(x => x.TypeId).ToList();
                foreach (var gct in groupedcrmOppoList)
                {
                    var gctObj = Newtonsoft.Json.JsonConvert.SerializeObject(gct,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                       });
                    crmSalesmanReportObject.OpportunityResult.Add(gctObj);
                }


            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmSalesmanReportObject);
        }

        [HttpGet("GetSalesmanOverviewReport/{monthId}/{yearId}/{salesmanIds}")]
        public async Task<IActionResult> GetSalesmanOverviewReport(int monthId, int yearId, string salesmanIds)
        {
            List<long> salesmanIdlist = salesmanIds.Split(',').Select(long.Parse).ToList();
            var jsonObject = new JObject();
            dynamic crmSalesmanOverviewReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity.Where(x => x.Date.Value.Month == monthId && x.Date.Value.Year == yearId && salesmanIdlist.Contains(x.Owner.Id))
                   //  var listOfData = await DBContext.Crmopportunity.Where(x => x.Date.Value.Month == monthId && x.OwnerId == salesmanId)
                   .Include(x => x.Lead)
                    .Include("Lead.CrmleadReference")
                    .Include(x => x.Account)
                     .Include("Lead.Crmtask")
                    .ToListAsync();
                var populatedResult = listOfData.Select(x => new
                {
                    Lead = x.Lead,
                    Account = x.Account,
                    Opportunity = x,
                    Contact = x.Lead.CrmleadReference,
                    Task = x.Lead.Crmtask,
                    Sales = "nil"

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmSalesmanOverviewReportObject.Results = new JArray() as dynamic;
                crmSalesmanOverviewReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmSalesmanOverviewReportObject);
        }

        [HttpGet("GetAccountsReport/{branchId}/{UserId}")]
        public async Task<IActionResult> GetAccountsReport(long branchId, long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmAccountsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {

                var crmCustomerList = await DBContext.User.Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1 && x.BasicDetail.BranchId == branchId 
                && (x.BasicDetail.SalesExecutiveId == UserId || UserId == 0))
                                  .Select(x => new
                                  {
                                      Id = x.Id,
                                      Date = x.BasicDetail != null ? x.BasicDetail.CreatedDate : null,
                                      Account = x.BasicDetail != null ? x.BasicDetail.IncorporatedName : "",
                                      Telephone = x.BasicDetail != null ? x.BasicDetail.TelephoneNo : "",
                                      Email = x.BasicDetail != null ? x.BasicDetail.EmailId : "",
                                      Mobile = x.BasicDetail != null ? x.BasicDetail.MobileNo : "",
                                      AccountOwnerName = x.BasicDetail != null && x.BasicDetail.SalesExecutive != null && x.BasicDetail.SalesExecutive.BasicDetail != null ? x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName : "",
                                  }).OrderByDescending(x => x.Date).ToListAsync();

                //var listOfData = await DBContext.Crmopportunity
                //    .Include(x => x.Lead)
                //    .Include(x => x.Account)
                //    .Include(x => x.Owner)
                //    .Include("Account.BasicDetail")
                //    .Include("Owner.BasicDetail")
                //    .ToListAsync();
                var populatedResult = crmCustomerList.Select(x => new AccountsReportViewModel
                {
                    AccountDate = x.Date,
                    AccountOwner = x.AccountOwnerName,
                    AccountName = x.Account,
                    AccountMobile = x.Mobile,
                    AccountPhone = x.Telephone,
                    AccountEmail = x.Email

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmAccountsReportObject.Results = new JArray() as dynamic;
                crmAccountsReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmAccountsReportObject);
        }

        [HttpPost("GetEmployeeAllocationReport")]
        public async Task<IActionResult> GetEmployeeAllocationReport([FromBody] RequestHeader request)
        {
            var jsonObject = new JObject();
            dynamic crmAccountsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                DateTime now = DateTime.Now;
                var prjIds = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == request.UserId && x.ProjectTypeId == 1 ).Select(x => x.Id).ToListAsync();
              
                if(request.Mobilized ==1)
                {
                    var nocMobilizedDetails = await DBContext.NocDetails.Where(x => prjIds.Contains((long)x.ProjectId) && x.IsDeleted != 1 &&
                                   (x.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.IsDemobilized != 1 && y.MobilizeDate.Value.Date >= request.FromDate.Date && y.MobilizeDate.Value.Date <= request.ToDate.Date && y.NocDetailsId == x.Id)).Count() > 0)
                                       .Select(x => new
                                       {
                                           x.Id,
                                           x.Project.ProjectName,
                                           ClientName = x.Client.BasicDetail != null ? x.Client.BasicDetail.IncorporatedName : null,
                                           NocEmployeeDetails = x.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.IsDemobilized != 1 && y.MobilizeDate.Value.Date >= request.FromDate.Date && y.MobilizeDate.Value.Date <= request.ToDate.Date && y.NocDetailsId == x.Id)
                                           .Select(z => new
                                           {
                                               Id = z.Id,
                                               IncorporatedName = z.Employee.BasicDetail.IncorporatedName,
                                               Code = z.Employee.BasicDetail.Code,
                                               Reason = z.Reason != null ? z.Reason.Name : null,
                                               Trade = (z.Employee.JobDetailsUser.Count() > 0 && z.Employee.JobDetailsUser.FirstOrDefault().Designation != null)
                                              ? z.Employee.JobDetailsUser.FirstOrDefault().Designation.Name : null,
                                               PassportNumber = z.Employee.UserDetails == null ? null : z.Employee.UserDetails.PassportNumber,
                                               Nationality = z.Employee.BasicDetail.Country == null ? null : z.Employee.BasicDetail.Country.Name,
                                               DesignationId = z.Employee.JobDetailsUser.FirstOrDefault().DesignationId,
                                               Designation = z.Employee.JobDetailsUser.FirstOrDefault().Designation != null
                                               ? z.Employee.JobDetailsUser.FirstOrDefault().Designation.Name : null,
                                               z.Employee.BasicDetail.BranchId,
                                               z.MobilizeDate


                                           })
                                       }).ToListAsync();

                    var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(nocMobilizedDetails,
                                           new JsonSerializerSettings()
                                           {
                                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                           });
                    crmAccountsReportObject.Results = new JArray() as dynamic;
                    crmAccountsReportObject.Results.Add(jsonResult);

                }
                else
                {
                    var nocMobilizedDetails = await DBContext.NocDetails.Where(x => prjIds.Contains((long)x.ProjectId) && x.IsDeleted != 1 &&
               (x.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsDemobilized == 1 && y.DeMobilizeDate.Value.Date >= request.FromDate.Date && y.DeMobilizeDate.Value.Date <= request.ToDate.Date && y.NocDetailsId == x.Id)).Count() > 0)
                   .Select(x => new
                   {
                       x.Id,
                       x.Project.ProjectName,
                       ClientName = x.Client.BasicDetail != null ? x.Client.BasicDetail.IncorporatedName : null,
                       NocEmployeeDetails = x.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsDemobilized == 1 && y.DeMobilizeDate.Value.Date >= request.FromDate.Date && y.DeMobilizeDate.Value.Date <= request.ToDate.Date && y.NocDetailsId == x.Id)
                       .Select(z => new
                       {
                           Id = z.Id,
                           IncorporatedName = z.Employee.BasicDetail.IncorporatedName,
                           Code = z.Employee.BasicDetail.Code,
                           Reason = z.Reason != null ? z.Reason.Name : null,
                           DemobilizedReason = z.DeMobilizeReason != null ? z.DeMobilizeReason.Name:null,
                           Trade = (z.Employee.JobDetailsUser.Count() > 0 && z.Employee.JobDetailsUser.FirstOrDefault().Designation != null)
                          ? z.Employee.JobDetailsUser.FirstOrDefault().Designation.Name : null,
                           PassportNumber = z.Employee.UserDetails == null ? null : z.Employee.UserDetails.PassportNumber,
                           Nationality = z.Employee.BasicDetail.Country == null ? null : z.Employee.BasicDetail.Country.Name,
                           DesignationId = z.Employee.JobDetailsUser.FirstOrDefault().DesignationId,
                           Designation = z.Employee.JobDetailsUser.FirstOrDefault().Designation != null
                           ? z.Employee.JobDetailsUser.FirstOrDefault().Designation.Name : null,
                           z.Employee.BasicDetail.BranchId,
                           z.DeMobilizeDate

                       })
                   }).ToListAsync();

                    var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(nocMobilizedDetails,
                                           new JsonSerializerSettings()
                                           {
                                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                           });
                    crmAccountsReportObject.Results = new JArray() as dynamic;
                    crmAccountsReportObject.Results.Add(jsonResult);

                }
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmAccountsReportObject);
        }


        [HttpPost("GetNewClientsReport")]
        public async Task<IActionResult> GetNewClientsReport([FromBody] RequestHeader request)
        {
            var jsonObject = new JObject();
            dynamic crmAccountsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {

                var crmCustomerList = await DBContext.User.Where(x => x.UserRoleId == _crmCustomerRoleId && x.IsDeleted != 1
                && x.BasicDetail.CreatedDate.HasValue && (x.BasicDetail.CreatedDate.Value.Date >= request.FromDate.Date && x.BasicDetail.CreatedDate.Value.Date <= request.ToDate.Date)
                && x.BasicDetail.CreatedBy == request.UserId)
                                .Select(x => new
                                {
                                    Id = x.Id,
                                    Date = x.BasicDetail != null ? x.BasicDetail.CreatedDate : null,
                                    Account = x.BasicDetail != null ? x.BasicDetail.IncorporatedName : "",
                                    Telephone = x.BasicDetail != null ? x.BasicDetail.TelephoneNo : "",
                                    Email = x.BasicDetail != null ? x.BasicDetail.EmailId : "",
                                    Mobile = x.BasicDetail != null ? x.BasicDetail.MobileNo : "",
                                    AccountOwnerName = x.BasicDetail != null && x.BasicDetail.SalesExecutive != null && x.BasicDetail.SalesExecutive.BasicDetail != null ? x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName : "",
                                }).OrderByDescending(x => x.Date).ToListAsync();

                //var listOfData = await DBContext.Crmopportunity
                //    .Include(x => x.Lead)
                //    .Include(x => x.Account)
                //    .Include(x => x.Owner)
                //    .Include("Account.BasicDetail")
                //    .Include("Owner.BasicDetail")
                //    .ToListAsync();
                var populatedResult = crmCustomerList.Select(x => new AccountsReportViewModel
                {
                    AccountDate = x.Date,
                    AccountOwner = x.AccountOwnerName,
                    AccountName = x.Account,
                    AccountMobile = x.Mobile,
                    AccountPhone = x.Telephone,
                    AccountEmail = x.Email

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmAccountsReportObject.Results = new JArray() as dynamic;
                crmAccountsReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmAccountsReportObject);
        }



        [HttpPost("GetSalesPersonWiseReport")]
        public async Task<IActionResult> GetSalesPersonWiseReport([FromBody] ReportHeader request)
        {
            var jsonObject = new JObject();
            dynamic SalesPersonWiseReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var startDate = new DateTime(request.Year, request.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                var month = new DateTime(request.Year, request.Month, 1);
                var secondLastMonthFirstDay = month.AddMonths(-2);
                var secondLastMonthLastDay = secondLastMonthFirstDay.AddMonths(1).AddDays(-1);


                var prjIds = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == request.SalesExecutiveId && x.ProjectTypeId == 1).Select(x => x.Id).ToListAsync();
                var projects = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == request.SalesExecutiveId && x.ProjectTypeId == 1).ToListAsync();

                var invIds = await DBContext.ClientInvoiceProject.Where(x => prjIds.Contains((long)x.ProjectId) && x.IsDeleted != 1).Select(x => x.AccountUserInvoiceId).Distinct().ToListAsync();

                var invList = await DBContext.AccountUserInvoice.Where(x => invIds.Contains(x.Id) && x.IsDeleted != 1 && x.FromDate.Value.Date >= secondLastMonthFirstDay.Date && x.ToDate.Value.Date <= endDate.Date).ToListAsync();

                    var SalesTargetList = await DBContext.User.Where(x => x.Id == request.SalesExecutiveId).Select(x => new
                    {
                        SalesTarget = x.BasicDetail.SalesTarget.HasValue ? x.BasicDetail.SalesTarget.Value : 0

                    }).ToListAsync();
                     var SalesTarget = SalesTargetList.FirstOrDefault().SalesTarget;

                var InvoicedAmount = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == request.SalesExecutiveId && x.ProjectTypeId == 1)
                    .Select(x => new
                    {
                        ProjectName = x.ProjectName,
                        ProjectId = x.Id,
                        ClientTimeSheetProject =x.ClientInvoiceProject.Where(y => y.ProjectId == x.Id && y.IsDeleted != 1)
                          .Select(k => new
                          {
                              //accountuserInvoice = k.AccountUserInvoice,
                              InvoiceNo =k.AccountUserInvoice.InvoiceNo ,
                              InvoiceDate =k.AccountUserInvoice.InvoiceDate ,
                              NetTotal = k.AccountUserInvoice.InvoiceAmount 
                          })
                    }).ToListAsync();


                var CollectedAmount = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == request.SalesExecutiveId && x.ProjectTypeId == 1).Select(x => new
                    {
                        ProjectName = x.ProjectName,
                        ProjectId = x.Id,
                        ClientTimeSheetProject = x.ClientInvoiceProject.Where(y => y.ProjectId == x.Id && y.IsDeleted != 1)
                         .Select(x => new
                         {
                             //accountuserInvoice = x.AccountUserInvoice,
                             InvoiceNo = x.AccountUserInvoice.InvoiceNo,
                             InvoiceDate = x.AccountUserInvoice.InvoiceDate,
                             //CollectedAmount = (x.InvoiceAmount ?? 0) - (x.BalanceAmountPr ?? 0)
                             CollectedAmount = 0
                         })
                    }).ToListAsync();
                    var jsonSalesTarget = Newtonsoft.Json.JsonConvert.SerializeObject(SalesTarget,
                                           new JsonSerializerSettings()
                                           {
                                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                           });
                    SalesPersonWiseReportObject.SalesTarget = new JArray() as dynamic;
                    SalesPersonWiseReportObject.SalesTarget.Add(jsonSalesTarget);
                var jsonInvoicedAmount = Newtonsoft.Json.JsonConvert.SerializeObject(InvoicedAmount,
                                         new JsonSerializerSettings()
                                         {
                                             ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                         });
                SalesPersonWiseReportObject.InvoicedAmount = new JArray() as dynamic;
                SalesPersonWiseReportObject.InvoicedAmount.Add(jsonInvoicedAmount);

                var jsonCollectedAmount = Newtonsoft.Json.JsonConvert.SerializeObject(CollectedAmount,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                SalesPersonWiseReportObject.CollectedAmount = new JArray() as dynamic;
                SalesPersonWiseReportObject.CollectedAmount.Add(jsonCollectedAmount);


            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(SalesPersonWiseReportObject);
        }


        [HttpGet("GetCampaignReport/{statusId}")]
        public async Task<IActionResult> GetCampaignReport(int statusId)
        {
            var jsonObject = new JObject();
            dynamic crmCampaignReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity
                    .Include(x => x.Lead)
                    .Include(x => x.Account)
                    .Include(x => x.Owner)
                    .Include("Account.BasicDetail")
                    .Include("Owner.BasicDetail")
                    .ToListAsync();
                var populatedResult = listOfData.Select(x => new CampaignReportViewModel
                {
                    Campaign = "nil",
                    CampaignStatus = "nil",
                    CampaignStartDate = "nil",
                    CampaignEndDate = "nil",
                    CampaignDuration = "nil"

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmCampaignReportObject.Results = new JArray() as dynamic;
                crmCampaignReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmCampaignReportObject);
        }

        [HttpGet("GetClientsReport/{startdate},{enddate},{branchId},{UserId}")]
        public async Task<IActionResult> GetClientsReport(DateTime startdate, DateTime enddate, long branchId, long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmClientsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity.Where(x => x.Lead.Date.Value.Date >= startdate.Date && x.Lead.Date.Value.Date <= enddate.Date && x.StatusId == 7 && x.BranchId == branchId && ( x.Lead.AssignedSalesExecutiveId == UserId || UserId == 0) && x.IsDeleted != 1)
                    .Include(x => x.Lead)
                    .Include(x => x.Owner)
                    .Include("Owner.BasicDetail")
                    .Include("Lead.Client.BasicDetail")
                     .Include("Lead.AssignedSalesExecutive.BasicDetail")
                     .ToListAsync();
                var populatedResult = listOfData.Select(x => new ClientsReportViewModel
                {
                    LeadDate = x.Lead.Date,
                    // ClientOwner = (x.Owner != null && x.Owner.BasicDetail != null) ?
                    //     x.Owner.BasicDetail.IncorporatedName : null,
                    // ClientName = x.OpportunityName,
                                         
                    ClientOwner = x.Lead.AssignedSalesExecutive.BasicDetail.FirstName,
                    ClientName = (x.Owner != null && x.Owner.BasicDetail != null) ?
                       //  x.Owner.BasicDetail.IncorporatedName : null,
                       x.Lead.Client.BasicDetail.IncorporatedName: null,
                    ClientId = x.Lead.ClientId,
                    ClientEmail = x.LeadId != null && x.Lead.ClientId != null ? x.Lead.Client.BasicDetail.EmailId : "",
                    ClientPhone = x.LeadId != null && x.Lead.ClientId != null ? x.Lead.Client.BasicDetail.TelephoneNo : ""

                }).ToList();
                var distinctResult = populatedResult.GroupBy(x => x.ClientId, (key, group) => group.First());
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(distinctResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmClientsReportObject.Results = new JArray() as dynamic;
                crmClientsReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmClientsReportObject);
        }

        [HttpGet("GetContactsReport/{startdate},{enddate},{branchId},{UserId}")]
        public async Task<IActionResult> GetContactsReport(DateTime startdate, DateTime enddate, long branchId, long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmContactsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                //var listOfData = await DBContext.Crmopportunity.Where(x => x.Lead.Date >= startdate && x.Lead.Date <= enddate)
                //    .Include(x => x.Lead).ThenInclude(x => x.CrmleadReference)
                //    .Include(x => x.Owner)
                //    .Include("Owner.BasicDetail")
                //    .ToListAsync();

                var listOfReference = await DBContext.CrmleadReference.Where(x => x.Crmlead.Date.Value.Date >= startdate.Date && x.Crmlead.Date.Value.Date <= enddate.Date && x.Crmlead.BranchId == branchId 
                && (x.Crmlead.AssignedSalesExecutiveId == UserId || UserId == 0) && x.IsDeleted != 1)
                    .Include(x => x.Crmlead).ThenInclude(x => x.AssignedSalesExecutive.BasicDetail)
                    .ToListAsync();

                var populatedResult = listOfReference.Select(x => new ContactsReportViewModel
                {
                    ContactOwner = (x.Crmlead != null && x.Crmlead.AssignedSalesExecutive != null && x.Crmlead.AssignedSalesExecutive.BasicDetail != null) ?
                        x.Crmlead.AssignedSalesExecutive.BasicDetail.IncorporatedName : null,
                    ContactName = x.Name,
                    ContactEmail = x.Email,
                    ContactMobile = x.ContactNo

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmContactsReportObject.Results = new JArray() as dynamic;
                crmContactsReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmContactsReportObject);
        }

        [HttpGet("GetLeadsReport/{statusId},{branchId},{UserId}")]
        public async Task<IActionResult> GetLeadsReport(int statusId, long branchId,long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmLeadsReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmlead.Where(x => x.BranchId == branchId && x.IsDeleted != 1 &&(x.AssignedSalesExecutiveId == UserId || UserId == 0) && (x.LeadStatusId == statusId || statusId == 0))
                    .Include(x => x.Client)
                    .Include(x => x.AssignedSalesExecutive.BasicDetail)
                    .Include("Client.BasicDetail")
                    .Include(x => x.LeadStatus)
                    .Include(x => x.WorkCategory)
                    .ToListAsync();
                var populatedResult = listOfData.Select(x => new LeadsReportViewModel
                {
                    LeadDate = x.Date,
                    LeadName = (x.Client != null && x.Client.BasicDetail != null) ?
                        x.Client.BasicDetail.IncorporatedName : null,
                    LeadOwner = x.AssignedSalesExecutive != null && x.AssignedSalesExecutive.BasicDetail != null ? x.AssignedSalesExecutive.BasicDetail.IncorporatedName : "",
                    LeadStatus = x.LeadStatus != null ? x.LeadStatus.Status : "",
                    Work = x.WorkCategory==null?"": x.WorkCategory.Name
                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmLeadsReportObject.Results = new JArray() as dynamic;
                crmLeadsReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmLeadsReportObject);
        }

        [HttpGet("GetOpportunitiesReport/{branchId},{UserId}")]
        public async Task<IActionResult> GetOpportunitiesReport(long branchId, long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmOpportunitiesReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity.Where(x => x.BranchId == branchId && (x.Lead.AssignedSalesExecutiveId == UserId || UserId == 0) && x.IsDeleted != 1)
                    .Include(x => x.Lead)
                    .Include(x => x.Owner)
                    .Include(x => x.Status)
                    .Include("Owner.BasicDetail")
                     .Include(x => x.Account)
                     .Include("Account.BasicDetail")
                    .ToListAsync();
                var populatedResult = listOfData.Select(x => new OpportunitiesReportViewModel
                {
                    OpportunityClosedDate = (x.Date != null) ? x.Date : null,
                    OpportunityOwner = (x.Owner != null && x.Owner.BasicDetail != null) ?
                        x.Owner.BasicDetail.IncorporatedName : null,
                    OpportunityNumber = x.OpportunityNumber,
                    OpportunityName = x.OpportunityName,
                    OpportunityComment = x.Comments,
                    Stage = (x.Status != null) ? x.Status.Status : null,
                    AccountName = (x.Account != null && x.Account.BasicDetail != null) ?
                        x.Account.BasicDetail.IncorporatedName : null
                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmOpportunitiesReportObject.Results = new JArray() as dynamic;
                crmOpportunitiesReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmOpportunitiesReportObject);
        }

        [HttpGet("GetSalesReport/{SponsorshipCompanyId},{UserId},{FromDate},{ToDate}")]
        public async Task<IActionResult> GetSalesReport(long SponsorshipCompanyId, long UserId,DateTime FromDate, DateTime ToDate)
        {
            var jsonObject = new JObject();
            dynamic crmSalesReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                List<SalesReportViewModel> salesReportViewModel = new List<SalesReportViewModel>();
                var clientInvoiceList = await DBContext.AccountUserInvoice.Where(x => x.SponsorshipCompanyId == SponsorshipCompanyId && x.IsDeleted != 1 && x.UserRoleId == 3 && (x.InvoiceDate.HasValue && x.InvoiceDate.Value.Date >= FromDate.Date  ) && (x.InvoiceDate.HasValue && x.InvoiceDate.Value.Date <= ToDate.Date)
                &&(( x.ClientInvoiceProject.FirstOrDefault() != null && x.ClientInvoiceProject.FirstOrDefault().Project != null &&  x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutiveId == UserId) || UserId == 0))
                    .Include(x => x.User).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.ClientInvoiceProject).ThenInclude(x => x.Project).ThenInclude(x => x.SalesExecutive).ThenInclude(x => x.BasicDetail).ToListAsync();

                if (clientInvoiceList != null && clientInvoiceList.Count > 0)
                {
                    clientInvoiceList.ForEach(x =>
                    {
                        var salesReport = new SalesReportViewModel();
                        salesReport.AccountName = x.User != null && x.User.BasicDetail != null ? x.User.BasicDetail.IncorporatedName : "";
                        salesReport.Owner = x.ClientInvoiceProject.FirstOrDefault() != null && x.ClientInvoiceProject.FirstOrDefault().Project != null && x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive != null && x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive.BasicDetail != null ? x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive.BasicDetail.IncorporatedName : "";
                        salesReport.OpportunityName = x.User != null && x.User.BasicDetail != null ? x.User.BasicDetail.IncorporatedName : "";
                        salesReport.InvoiceDate = x.InvoiceDate;
                        salesReport.InvoiceNumber = x.InvoiceNo;
                        salesReport.InvoiceAmount = x.Total;
                        salesReport.InvoiceDiscount = "0";
                        salesReport.InvoiceVAT = x.Vat;
                        salesReport.InvoiceTotal = x.NetTotal;
                        salesReport.AccountUserInvoiceId = x.Id;
                        salesReportViewModel.Add(salesReport);
                    });
                }

                //var clientInvoiceList = await DBContext.AccountUserInvoice.Where(x => x.SponsorshipCompanyId == SponsorshipCompanyId && x.IsDeleted != 1 && x.UserRoleId == 3)
                //                        .Select(x => new SalesReportViewModel
                //                        {
                //                            AccountName = x.User != null && x.User.BasicDetail != null ? x.User.BasicDetail.FirstName + " " + x.User.BasicDetail.MiddleName : "",
                //                            Owner = x.ClientInvoiceProject.FirstOrDefault() != null && x.ClientInvoiceProject.FirstOrDefault().Project != null && x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive != null && x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive.BasicDetail != null ? x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive.BasicDetail.FirstName + " " + x.ClientInvoiceProject.FirstOrDefault().Project.SalesExecutive.BasicDetail.MiddleName : "",
                //                            OpportunityName = x.User != null && x.User.BasicDetail != null ? x.User.BasicDetail.FirstName + " " + x.User.BasicDetail.MiddleName : "",
                //                            InvoiceDate = x.InvoiceDate,
                //                            InvoiceNumber = x.InvoiceNo,
                //                            InvoiceAmount = x.Total,
                //                            InvoiceDiscount = "0",
                //                            InvoiceVAT = x.Vat,
                //                            InvoiceTotal = x.NetTotal
                //                        }).ToListAsync();


                //var listOfData = await DBContext.Crmopportunity
                //    .Include(x => x.Lead)
                //    .Include(x => x.Owner)
                //    .Include(x => x.Status)
                //    .Include("Owner.BasicDetail")
                //     .Include(x => x.Account)
                //     .Include("Account.BasicDetail")
                //    .ToListAsync();
                //var populatedResult = listOfData.Select(x => new SalesReportViewModel
                //{
                //    AccountName = (x.Account != null && x.Account.BasicDetail != null) ?
                //        x.Account.BasicDetail.IncorporatedName : null,
                //    Owner = (x.Owner != null && x.Owner.BasicDetail != null) ?
                //        x.Owner.BasicDetail.IncorporatedName : null,
                //    OpportunityName = x.Lead.CompanyName,
                //    InvoiceDate = (x.Account != null && x.Account.AccountInvoice != null && x.Account.AccountInvoice.Count > 0 && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails != null && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.Count > 0) ?
                //        x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.FirstOrDefault().InvoiceDate : null,
                //    InvoiceNumber = (x.Account != null && x.Account.AccountInvoice != null && x.Account.AccountInvoice.Count > 0 && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails != null && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.Count > 0) ?
                //        x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.FirstOrDefault().InvoiceNo : null,
                //    InvoiceAmount = (x.Account != null && x.Account.AccountInvoice != null && x.Account.AccountInvoice.Count > 0 && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails != null && x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.Count > 0) ?
                //        x.Account.AccountInvoice.FirstOrDefault().AccountInvoiceDetails.FirstOrDefault().Amount : null,
                //    InvoiceDiscount = "nil",
                //    InvoiceVAT = "nil",
                //    InvoiceTotal = "nil"
                //}).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(salesReportViewModel,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmSalesReportObject.Results = new JArray() as dynamic;
                crmSalesReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmSalesReportObject);
        }

        [HttpGet("GetTargetReport/{yearId}/{salesmanIds}")]
        public async Task<IActionResult> GetTargetReport(int yearId, string salesmanIds)
        {
            List<long> salesmanIdlist = salesmanIds.Split(',').Select(long.Parse).ToList();
            var jsonObject = new JObject();
            dynamic crmTargetReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                var listOfData = await DBContext.Crmopportunity.Where(x => x.Date.Value.Year == yearId && salesmanIdlist.Contains(x.Owner.Id))
                    //  var listOfData = await DBContext.Crmopportunity.Where(x => x.Date.Value.Month == monthId && x.OwnerId == salesmanId)
                    .Include(x => x.Owner)
                    .Include("Owner.BasicDetail")
                    .ToListAsync();
                var populatedResult = listOfData.Select(x => new TargetReportViewModel
                {
                    SalesmanName = (x.Owner != null && x.Owner.BasicDetail != null) ?
                        x.Owner.BasicDetail.IncorporatedName : null,
                    TargetAmount = "nil",
                    ClosedAmount = "nil"

                }).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(populatedResult,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmTargetReportObject.Results = new JArray() as dynamic;
                crmTargetReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmTargetReportObject);
        }

        [HttpGet("GetTasksReport/{branchId},{UserId}")]
        public async Task<IActionResult> GetTasksReport(long branchId, long UserId)
        {
            var jsonObject = new JObject();
            dynamic crmTasksReportObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty success = new JProperty("SuccessMessage", "Success");
            try
            {
                //var listOfData = await DBContext.Crmopportunity
                //    .Include(x => x.Lead)
                //    .Include("Lead.Crmtask")
                //    .Include("Lead.Crmtask.CrmtaskDetail")
                //    .ToListAsync();
                var listOfData = await DBContext.Crmtask.Where(x => x.BranchId == branchId && (x.TaskAssignedTo == UserId || UserId == 0) && x.IsDeleted != 1)
                    .Include(x => x.TaskAssignedByNavigation).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.TaskOwner).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Priority)
                    .Include(x => x.CrmtaskDetail).ThenInclude(x => x.Status)
                    .Include(x => x.CrmtaskDetail).ThenInclude(x => x.TaskType)
                    .Include(x => x.Status)
                    .Include(x => x.TaskType)
                    .Include(x => x.Opportunity).ThenInclude(x => x.Lead).ThenInclude(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Lead).ThenInclude(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .Include(x => x.Project).ThenInclude(x => x.Client).ThenInclude(x => x.BasicDetail)
                    .ToListAsync();
                List<TasksReportViewModel> dataList = new List<TasksReportViewModel>();
                if (listOfData != null)
                {
                    listOfData.ForEach(x =>
                    {
                        TasksReportViewModel task = new TasksReportViewModel();
                        //task.TaskDueDate = ";

                        task.TaskType = x.TaskType != null ? x.TaskType.Type : "";
                        task.taskId = x.CaseId;
                        task.TaskCreatedDate = x.TaskCreatedDate;
                        task.TaskCompletedDate = x.TaskCompletedDate;
                        task.IsTask = "MainTask";
                        task.TaskUnder = x.TaskAssignedByNavigation != null && x.TaskAssignedByNavigation.BasicDetail != null ? x.TaskAssignedByNavigation.BasicDetail.IncorporatedName : "";
                        task.TaskOwner = x.TaskOwner != null && x.TaskOwner.BasicDetail != null ? x.TaskOwner.BasicDetail.IncorporatedName : "";
                        task.TaskPriority = x.Priority != null ? x.Priority.Priority : "";
                        //task.TaskComment = x.Comments;
                        task.Client = x.TaskOnId == 1 ? (x.Lead != null && x.Lead.Client != null && x.Lead.Client.BasicDetail != null ? x.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                  (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null && x.Opportunity.Lead.Client != null && x.Opportunity.Lead.Client.BasicDetail != null ? x.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                  (x.Project != null && x.Project.Client != null && x.Project.Client.BasicDetail != null ? x.Project.Client.BasicDetail.IncorporatedName : ""));
                        task.Project = x.TaskOnId == 1 ? (x.Lead != null ? x.Lead.ProjectName : "") :
                                                    (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null ? x.Opportunity.Lead.ProjectName : "") :
                                                    (x.Project != null ? x.Project.ProjectName : ""));
                        task.TaskStatus = x.Status != null ? x.Status.Status : "";
                        dataList.Add(task);

                        if (x.CrmtaskDetail != null && x.CrmtaskDetail.Count > 0)
                        {
                            x.CrmtaskDetail.ToList().ForEach(z =>
                            {

                                TasksReportViewModel subtask = new TasksReportViewModel();
                                subtask.taskId = x.CaseId;
                                subtask.TaskDueDate = z.FollowupDate;
                                subtask.IsTask = "SubTask";
                                subtask.TaskCreatedDate = x.TaskCreatedDate;
                                subtask.TaskCompletedDate = z.TaskCompletedDate;
                                subtask.TaskUnder = x.TaskAssignedByNavigation != null && x.TaskAssignedByNavigation.BasicDetail != null ? x.TaskAssignedByNavigation.BasicDetail.IncorporatedName : "";
                                subtask.TaskOwner = x.TaskOwner != null && x.TaskOwner.BasicDetail != null ? x.TaskOwner.BasicDetail.IncorporatedName : "";
                                subtask.TaskPriority = x.Priority != null ? x.Priority.Priority : "";
                                subtask.TaskComment = z.Comments;
                                subtask.TaskStatus = z.Status != null ? z.Status.Status : "";
                                subtask.Client = x.TaskOnId == 1 ? (x.Lead != null && x.Lead.Client != null && x.Lead.Client.BasicDetail != null ? x.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                 (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null && x.Opportunity.Lead.Client != null && x.Opportunity.Lead.Client.BasicDetail != null ? x.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                 (x.Project != null && x.Project.Client != null && x.Project.Client.BasicDetail != null ? x.Project.Client.BasicDetail.IncorporatedName : ""));
                                subtask.Project = x.TaskOnId == 1 ? (x.Lead != null ? x.Lead.ProjectName : "") :
                                                            (x.TaskOnId == 2 ? (x.Opportunity != null && x.Opportunity.Lead != null ? x.Opportunity.Lead.ProjectName : "") :
                                                            (x.Project != null ? x.Project.ProjectName : ""));
                                subtask.TaskType = z.TaskType != null ? z.TaskType.Type : "";
                                dataList.Add(subtask);
                            });
                        }
                    });
                }
                //var populatedResult = listOfData.Select(x => new TasksReportViewModel
                //{                   
                //    TaskDueDate = (x.Lead != null && x.Lead.Crmtask != null && x.Lead.Crmtask.Count > 0 && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail != null && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.Count > 0) ?
                //        x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.FirstOrDefault().UpdatedDate : null,
                //    TaskCompletedDate = (x.Lead != null && x.Lead.Crmtask != null && x.Lead.Crmtask.Count > 0 && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail != null && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.Count > 0) ?
                //        x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.FirstOrDefault().UpdatedDate : null,
                //    TaskUnder = x.Lead.CompanyName,
                //    TaskOwner = (x.Lead != null && x.Lead.Crmtask != null && x.Lead.Crmtask.Count > 0 && x.Lead.Crmtask.FirstOrDefault().TaskOwner != null && x.Lead.Crmtask.FirstOrDefault().TaskOwner.BasicDetail != null) ?
                //        x.Lead.Crmtask.FirstOrDefault().TaskOwner.BasicDetail.IncorporatedName : null,
                //    TaskPriority = (x.Lead != null && x.Lead.Crmtask != null && x.Lead.Crmtask.Count > 0 && x.Lead.Crmtask.FirstOrDefault().Priority != null) ?
                //        x.Lead.Crmtask.FirstOrDefault().Priority.Priority : null,
                //    TaskComment = (x.Lead != null && x.Lead.Crmtask != null && x.Lead.Crmtask.Count > 0 && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail != null && x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.Count > 0) ?
                //        x.Lead.Crmtask.FirstOrDefault().CrmtaskDetail.FirstOrDefault().Comments : null

                //}).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(dataList,
                                       new JsonSerializerSettings()
                                       {
                                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                                       });
                crmTasksReportObject.Results = new JArray() as dynamic;
                crmTasksReportObject.Results.Add(jsonResult);
            }
            catch (Exception ex) { success.Value = ""; error.Value = ex.Message; }
            jsonObject.Add(error);
            jsonObject.Add(success);
            return Ok(crmTasksReportObject);
        }

      
        #endregion

        #region CrmcompanyType
        [HttpPost("AddCrmcompanyType")]
        public async Task<IActionResult> AddCrmcompanyType([FromBody] CrmcompanyType value)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess1");
            JProperty Id = new JProperty("Id", "");
            try
            {
                var result = DBContext.CrmcompanyType.Update(value);
                DBContext.SaveChanges();
                if (result != null && result.Entity != null && result.Entity.Id > 0)
                    Id.Value = result.Entity.Id;
                else
                    Id.Value = 0;
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(Id);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmcompanyType")]
        public async Task<IActionResult> UpdateCrmcompanyType([FromBody] CrmcompanyType value)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmcompanyType.Update(value);
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic OutputObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(OutputObject);
        }
        [HttpPost("DeleteCrmcompanyType")]
        public async Task<IActionResult> DeleteCrmcompanyType([FromBody] CrmcompanyType value)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                value.IsDeleted = 1;
                DBContext.CrmcompanyType.Update(value);
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic OutputObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(OutputObject);
        }
        [HttpGet("GetCrmcompanyType/{Id}")]
        public async Task<IActionResult> GetCrmcompanyType(long Id)
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = (DBContext.CrmcompanyType.Where(x => x.IsDeleted != 1 && x.Id == Id)).FirstOrDefault();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }
        [HttpGet("GetAllCrmcompanyType")]
        public async Task<IActionResult> GetAllCrmcompanyType()
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmcompanyType.Where(x => x.IsDeleted != 1)).ToListAsync();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }
        #endregion

        #region CrmleadStatus
        [HttpPost("AddCrmleadStatus")]
        public async Task<IActionResult> AddCrmleadStatus([FromBody] CrmleadStatus value)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty Id = new JProperty("Id", "");
            try
            {
                var result = DBContext.CrmleadStatus.Update(value);
                DBContext.SaveChanges();
                if (result != null && result.Entity != null && result.Entity.Id > 0)
                    Id.Value = result.Entity.Id;
                else
                    Id.Value = 0;
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(Id);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }
        [HttpPost("UpdateCrmleadStatus")]
        public async Task<IActionResult> UpdateCrmleadStatus([FromBody] CrmleadStatus value)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CrmleadStatus.Update(value);
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic OutputObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(OutputObject);
        }
        [HttpPost("DeleteCrmleadStatus")]
        public async Task<IActionResult> DeleteCrmleadStatus([FromBody] CrmleadStatus value)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                value.IsDeleted = 1;
                DBContext.CrmleadStatus.Update(value);
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic OutputObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(OutputObject);
        }
        [HttpGet("GetCrmleadStatus/{Id}")]
        public async Task<IActionResult> GetCrmleadStatus(long Id)
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = (DBContext.CrmleadStatus.Where(x => x.IsDeleted != 1 && x.Id == Id)).FirstOrDefault();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }
        [HttpGet("GetAllCrmleadStatus")]
        public async Task<IActionResult> GetAllCrmleadStatus()
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.CrmleadStatus.Where(x => x.IsDeleted != 1)).ToListAsync();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }
        #endregion

        #region Opportunity

        [HttpGet("GetOpportunityByUserRole/{BranchId},{UserId},{UserRoleRuleId}")]
        public async Task<IActionResult> GetOpportunityByUserRole(long BranchId, long UserId, long UserRoleRuleId)
        {
            var _normalUserId = 5;
            var jsonObject = new JObject();
            dynamic dataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                dynamic result;
                if (UserRoleRuleId == _normalUserId)
                {
                    result = await DBContext.Crmopportunity
                        .Include(x => x.Lead)
                        .Where(x => x.BranchId == BranchId && x.Lead.AssignedSalesExecutiveId == UserId
                        && x.IsDeleted != 1).Select(x => new
                        {
                            OpportunityId = x.Id,
                            OpportunityNumber = x.OpportunityNumber,
                            OpportunityName = x.Lead.ProjectName
                        }).ToListAsync();
                }
                else
                {
                    result = await DBContext.Crmopportunity
                       .Include(x => x.Lead)
                       .Where(x => x.BranchId == BranchId
                       && x.IsDeleted != 1).Select(x => new
                       {
                           OpportunityId = x.Id,
                           OpportunityNumber = x.OpportunityNumber,
                           OpportunityName = x.Lead.ProjectName
                       }).ToListAsync();
                }
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

                dataObject.Results = new JArray() as dynamic;
                dataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
                //  _logger.LogError(ex, ex.Message);
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(dataObject);
        }

        #endregion

        #region CRM Dashboard

        [HttpGet("GetCRMDashboardData/{SalesExecutiveId}/{BranchId}")]
        public async Task<IActionResult> GetCRMDashboardData(long SalesExecutiveId, long BranchId)
        {
            var jsonObject = new JObject();
            dynamic commonDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {

                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var lastMonthFirstDay = month.AddMonths(-1);
                var lastMonthLastDay = month.AddDays(-1);

                var secondLastMonthFirstDay = month.AddMonths(-2);
                var secondLastMonthLastDay = secondLastMonthFirstDay.AddMonths(1).AddDays(-1);

                var prjIds = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == SalesExecutiveId && x.ProjectTypeId == 1).Select(x => x.Id).ToListAsync();
                var prjIdsCount = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == SalesExecutiveId && (x.ProjectTypeId == 1 || x.EndDate >= lastMonthFirstDay && x.StartDate <= lastMonthLastDay)).Select(x => x.Id).ToListAsync();

                var invIds = await DBContext.ClientInvoiceProject.Where(x => prjIds.Contains((long)x.ProjectId) && x.IsDeleted != 1).Select(x => x.AccountUserInvoiceId).Distinct().ToListAsync();

                var invList = await DBContext.AccountUserInvoice.Where(x => invIds.Contains(x.Id) && x.IsDeleted != 1 && x.FromDate.Value.Date >= secondLastMonthFirstDay.Date && x.ToDate.Value.Date <= endDate.Date).ToListAsync();

                var verutheSum = invList.Sum(x => x.InvoiceAmount);

                var BalanceAmountPr = invList.Where(x => invIds.Contains(x.Id) && x.IsDeleted != 1).Sum(x => x.BalanceAmountPr);

                var thisMonthInvAmount = invList.Where(x => x.FromDate.Value.Date >= startDate.Date && x.ToDate.Value.Date <= endDate.Date && x.IsDeleted != 1).Sum(x => x.InvoiceAmount);

                var lastMonthInvAmount = invList.Where(x => x.FromDate.Value.Date >= lastMonthFirstDay.Date && x.ToDate.Value.Date <= lastMonthLastDay.Date && x.IsDeleted != 1).Sum(x => x.InvoiceAmount);

                var secondLastMonthInvAmount = invList.Where(x => x.FromDate.Value.Date >= secondLastMonthFirstDay.Date && x.ToDate.Value.Date <= secondLastMonthLastDay.Date && x.IsDeleted != 1).Sum(x => x.InvoiceAmount);

                var thisMonthBalAmount = invList.Where(x => x.FromDate.Value.Date >= startDate.Date && x.ToDate.Value.Date <= endDate.Date && x.IsDeleted != 1).Sum(x => x.BalanceAmountPr);

                var lastMonthBalAmount = invList.Where(x => x.FromDate.Value.Date >= lastMonthFirstDay.Date && x.ToDate.Value.Date <= lastMonthLastDay.Date && x.IsDeleted != 1).Sum(x => x.BalanceAmountPr);

                var secondLastMonthBalAmount = invList.Where(x => x.FromDate.Value.Date >= secondLastMonthFirstDay.Date && x.ToDate.Value.Date <= secondLastMonthLastDay.Date && x.IsDeleted != 1).Sum(x => x.BalanceAmountPr);

                var thisMonthCollectedAmount = 0; // thisMonthInvAmount > thisMonthBalAmount ? thisMonthInvAmount - thisMonthBalAmount : 0; //temp until invoice fix
                var lastMonthCollectedAmount = 0; // lastMonthInvAmount > lastMonthBalAmount ? lastMonthInvAmount - lastMonthBalAmount : 0; //temp until invoice fix
                var secondLastMonthCollectedAmount = 0;// secondLastMonthInvAmount > secondLastMonthBalAmount ? secondLastMonthInvAmount - secondLastMonthBalAmount : 0; //temp until invoice fix

                var CurrentMonthTasks = DBContext.Crmtask.Where(x => x.TaskAssignedTo == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.TaskCreatedDate.Value.Date >= startDate.Date && x.TaskCreatedDate.Value.Date <= endDate.Date).Count();
                var PreviousMonthTasks = DBContext.Crmtask.Where(x => x.TaskAssignedTo == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.TaskCreatedDate.Value.Date >= (startDate.AddMonths(-1)).Date && x.TaskCreatedDate.Value <= (startDate.AddDays(-1)).Date).Count();
                var TaskDiff = PreviousMonthTasks > 0 ? (CurrentMonthTasks - PreviousMonthTasks) * 100 / PreviousMonthTasks : 0;

                var CurrentMonthLeadList = DBContext.Crmlead.Where(x => x.AssignedSalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.Date.Value.Date >= startDate.Date && x.Date.Value.Date <= endDate.Date).Select(x => new
                    {
                        CustomerName = x.Client.BasicDetail.IncorporatedName,
                        x.LeadNo,
                        ProcessDate = x.Date,
                        CompanyType = x.CompanyType.Type
                    }).ToList();
                var CurrentMonthLead = CurrentMonthLeadList.Count();
                var PreviousMonthLead = DBContext.Crmlead.Where(x => x.AssignedSalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.Date.Value.Date >= (startDate.AddMonths(-1)).Date && x.Date.Value.Date <= (startDate.AddDays(-1)).Date).Count();
                var LeadDiff = PreviousMonthLead > 0 ? (CurrentMonthLead - PreviousMonthLead) * 100 / PreviousMonthLead : 0;

                var CurrentMonthOpertunityList = DBContext.Crmopportunity.Where(x => x.Lead.AssignedSalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.Date.Value.Date >= startDate.Date && x.Date.Value.Date <= endDate.Date).Select(x => new
                    {
                        x.Lead.LeadNo,
                        x.OpportunityName,
                        x.OpportunityNumber,
                        x.Date
                    }).ToList();
                var CurrentMonthOpertunity = CurrentMonthOpertunityList.Count();
                var PreviousMonthOpertunity = DBContext.Crmopportunity.Where(x => x.Lead.AssignedSalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 &&
                    x.Date.Value.Date >= (startDate.AddMonths(-1)).Date && x.Date.Value <= (startDate.AddDays(-1)).Date).Count();
                var OpertunityDiff = PreviousMonthOpertunity > 0 ? (CurrentMonthOpertunity - PreviousMonthOpertunity) * 100 / PreviousMonthOpertunity : 0;

                var Tasks = await DBContext.Crmtask.Where(x => x.TaskAssignedTo == SalesExecutiveId && x.IsDeleted != 1)
                                                    .Include(x => x.TaskAssignedToNavigation).ThenInclude(x => x.BasicDetail)
                                                    .Include(x => x.Lead)
                                                    .Include(x => x.TaskType)
                                                    .Include(x => x.Status)
                                                    .OrderByDescending(x => x.Id).Take(10).ToArrayAsync();
                var TaskDetails = await DBContext.CrmtaskDetail.Where(x => x.Task.TaskAssignedTo == SalesExecutiveId && x.IsDeleted != 1 && x.Task.IsDeleted != 1).Include(x => x.TaskType).Include(x => x.Status).OrderByDescending(x => x.Id).Take(10).ToArrayAsync();

                decimal CompanyTotalProjects = DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId).Count();
                var CurrentMonthProjectsCount = DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId).Count();
                var CurrentMonthProjects =await DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId).Select(x => x.Id).ToArrayAsync();
                decimal UserTotalActivePrjs = DBContext.Project.Where(x => x.IsDeleted != 1 && x.BranchId == BranchId && x.ProjectTypeId == 1 && x.SalesExecutiveId == SalesExecutiveId).Count();

                decimal UserTotalActiveProjectPercentage = CompanyTotalProjects > 0 ? (UserTotalActivePrjs) * 100 / CompanyTotalProjects : 0;

                decimal CompanyTotalClients = DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId).Count(x => x.Client.IsActive == 1);
                var UserTotalClients = DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId && x.Client.IsActive == 1).Select(x => x.ClientId).Distinct().Count();
                var UserTotalClientsArray =await DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId && x.Client.IsActive == 1).Select(x => x.ClientId).Distinct().ToArrayAsync();
                var clientIds = await DBContext.Project.Where(x => x.IsDeleted != 1 && x.SalesExecutiveId == SalesExecutiveId && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.Client.IsActive == 1).Select(x => x.ClientId).ToListAsync();
              //  var CurrentMonthClientsCount = DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId ).Count(x => x.Client.IsActive == 1);
               // var CurrentMonthClients =await DBContext.Project.Where(x => x.IsDeleted != 1 && x.ProjectTypeId == 1 && x.BranchId == BranchId && x.SalesExecutiveId == SalesExecutiveId && x.Client.IsActive == 1).Select(x => x.Client.Id).ToArrayAsync();

                decimal UserTotalActiveClientsPercentage = CompanyTotalClients > 0 ? (UserTotalClients * 100) / CompanyTotalClients : 0;

                var CurrentMonthCustomer = DBContext.User.Where(x => x.UserRoleId == 7 && x.IsDeleted != 1 && x.BasicDetail.CreatedDate.HasValue &&
                x.BasicDetail.CreatedDate.Value.Date >= startDate.Date && x.BasicDetail.CreatedDate.Value.Date <= endDate.Date && x.BasicDetail.CreatedBy == SalesExecutiveId).Count();
                var PreviousMonthCustomer = DBContext.User.Where(x => x.UserRoleId == 7 && x.IsDeleted != 1 && x.BasicDetail.CreatedDate.HasValue &&
                x.BasicDetail.CreatedDate.Value.Date >= (startDate.AddMonths(-1)).Date && x.BasicDetail.CreatedDate.Value.Date <= (startDate.AddDays(-1)).Date && x.BasicDetail.CreatedBy == SalesExecutiveId).Count();
                var CustomerDiff = PreviousMonthCustomer > 0 ? (CurrentMonthCustomer - PreviousMonthCustomer) * 100 / PreviousMonthCustomer : PreviousMonthCustomer;


                var nocDetails = await DBContext.NocDetails.Where(x => prjIds.Contains((long)x.ProjectId) && x.IsDeleted != 1).Select(x => x.Id).ToListAsync();
                var nocDetailsCount = DBContext.NocDetails.Where(x => prjIds.Contains((long)x.ProjectId) && startDate <= x.DocDate && endDate >= x.DocDate
                       && x.NocStatusId != null && x.IsDeleted != 1).Select(x => x.Id).Count();

                var totalActiveEmployees = DBContext.User.Where(x => (x.UserRoleId == _labourRoleId || x.UserRoleId == _supplierLabourRoleId)  && x.BasicDetail.BranchId == BranchId && x.IsDeleted != 1 && x.BasicDetail.SponsorshipCompany.BranchId ==BranchId
                                                                         && x.BasicDetail.SponsorshipCompany.IsDeleted != 1).Distinct().Count(x => x.IsActive == 1);

                var EmpCount = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && /*y.NocDetails.DocDate.Value.Date >= startDate.Date &&*/ y.NocDetails.DocDate.Value.Date <= endDate.Date && nocDetails.Contains((long)y.NocDetailsId)).Select(x => x.EmployeeId).Distinct().Count();
                var nocEmpCount = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.IsDemobilized != 1 && y.MobilizeDate.Value.Date >= startDate.Date && y.MobilizeDate.Value.Date <= endDate.Date && nocDetails.Contains((long)y.NocDetailsId)).Select(x => x.EmployeeId).Distinct().Count();

                var totalNocEmpCount = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.IsDemobilized != 1 && nocDetails.Contains((long)y.NocDetailsId))
                                    .Select(x => x.EmployeeId).Distinct().Count();
                var nocDemobEmpCount = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsDemobilized == 1 && y.DeMobilizeDate.Value.Date >= startDate.Date && y.DeMobilizeDate.Value.Date <= endDate.Date && nocDetails.Contains((long)y.NocDetailsId)).Select(x => x.EmployeeId).Distinct().Count();

                var totalDemobNocEmpCount = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsDemobilized != 1 && nocDetails.Contains((long)y.NocDetailsId))
                                    .Select(x => x.EmployeeId).Distinct().Count();

                var preNocEmpList = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.MobilizeDate.Value.Date <= lastMonthLastDay.Date && ((!y.DeMobilizeDate.HasValue) || (y.DeMobilizeDate.HasValue && y.DeMobilizeDate.Value.Date >= lastMonthFirstDay.Date))/* y.MobilizeDate.Value.Date >= lastMonthFirstDay && y.MobilizeDate.Value.Date <= lastMonthLastDay */
                    && nocDetails.Contains((long)y.NocDetailsId)).Select(x => x.EmployeeId);
                var preNocEmpLists = DBContext.NocEmployeeDetails.Where(y => y.IsDeleted != 1 && y.IsCancelled != 1 && y.IsMobilized == 1 && y.MobilizeDate.Value.Date <= lastMonthLastDay.Date  && ((!y.DeMobilizeDate.HasValue) || (y.DeMobilizeDate.HasValue && y.DeMobilizeDate.Value.Date >= lastMonthFirstDay.Date ))/* y.MobilizeDate.Value.Date >= lastMonthFirstDay && y.MobilizeDate.Value.Date <= lastMonthLastDay */
                    && nocDetails.Contains((long)y.NocDetailsId)).Select(x => new { x.EmployeeId, x.NocDetails.ProjectId,x.NocDetails.Project.ClientId , x.TradeChangeId});
                var preNocEmpCount = preNocEmpLists.Distinct().Count();

                var preNocEmpListTemp = preNocEmpLists.Select(x => new { EmployeeId = x.EmployeeId.Value, ProjectId = x.ProjectId.Value, DesignationId = x.TradeChangeId.Value }).ToList();

                var clientTimesheets = await DBContext.ClientTimeSheetProject.Where(x => x.Project.SalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 && x.ClientTimeSheet.IsDeleted != 1   &&
                (lastMonthFirstDay >= x.ClientTimeSheet.FromDate.Value.Date && lastMonthFirstDay <= x.ClientTimeSheet.ToDate.Value.Date)
                || (lastMonthLastDay >= x.ClientTimeSheet.FromDate.Value.Date && lastMonthLastDay <= x.ClientTimeSheet.ToDate.Value.Date)
                || (lastMonthFirstDay < x.ClientTimeSheet.FromDate.Value.Date && lastMonthLastDay > x.ClientTimeSheet.ToDate.Value.Date))
                //x.ClientTimeSheet.FromDate <= lastMonthFirstDay && x.ClientTimeSheet.ToDate >=lastMonthLastDay )
                .Select(x => x.ClientTimeSheetId).Distinct().ToArrayAsync();
             
                var timesheetCollectedData = DBContext.ClientTimeSheetEmployee.Where(x =>  x.DesignationId!= null && /*clientTimesheets.Contains(x.ClientTimeSheetId) &&*/
                x.ClientTimeSheet.IsDeleted!= 1&& preNocEmpList.Contains(x.EmployeeId) && x.IsDeleted != 1 
                && prjIds.Contains(x.ProjectId.Value) && x.Day.Value.Year == lastMonthFirstDay.Year && x.Day.Value.Month == lastMonthFirstDay.Month)
                .Select(x => new { EmployeeId = x.EmployeeId.Value, ProjectId =x.ProjectId.Value, DesignationId =x.DesignationId.Value }).Distinct().ToList();
                var timesheetCollected = timesheetCollectedData.Count();

                var timesheetCollectedProject = DBContext.ClientTimeSheetEmployee.Where(x => /*clientTimesheets.Contains(x.ClientTimeSheetId) &&*/x.ClientTimeSheet.IsDeleted != 1 && preNocEmpList.Contains(x.EmployeeId) && x.IsDeleted != 1
               && x.Project.SalesExecutiveId == SalesExecutiveId && x.Day.Value.Year == lastMonthFirstDay.Year && x.Day.Value.Month == lastMonthFirstDay.Month)
                .Select(x => x.ProjectId).Distinct().Count();
              
                var timesheetCollectedList = timesheetCollectedData.Select(x => x.EmployeeId).ToArray();
              
                var extra = timesheetCollectedData.Where(x => !preNocEmpListTemp.Contains(x)).ToList();

                preNocEmpCount = preNocEmpCount + extra.Distinct().Count();
                decimal timesheetMissedPer = preNocEmpCount > timesheetCollected ? preNocEmpCount - timesheetCollected : 0;

                decimal timesheetCollectedPer = timesheetCollected > preNocEmpCount ? preNocEmpCount : timesheetCollected;

                decimal timesheetCollectedPercentage = preNocEmpCount > 0 ? (timesheetCollectedPer * 100) / preNocEmpCount : 0;
                decimal timesheetMissedPercentage = preNocEmpCount > 0 ? (timesheetMissedPer * 100) / preNocEmpCount : 0;

                decimal CompanyTotalSales = DBContext.ClientInvoiceProject.Where(x => x.IsDeleted != 1 && x.AccountUserInvoice.IsDeleted != 1 && x.AccountUserInvoice.SponsorshipCompany.BranchId == BranchId)
                                       .Select(x => x.AccountUserInvoiceId).Distinct().Count();
                decimal UserTotalSales = DBContext.ClientInvoiceProject.Where(x => x.Project.SalesExecutiveId == SalesExecutiveId && x.IsDeleted != 1 && x.AccountUserInvoice.IsDeleted != 1 && x.AccountUserInvoice.SponsorshipCompany.BranchId == BranchId)
                                      .Select(x => x.AccountUserInvoiceId).Distinct().Count();
                decimal TotalActiveSalesCount = DBContext.ClientInvoiceProject.Where(x => x.Project.SalesExecutiveId == SalesExecutiveId && x.Project.ProjectTypeId==1 && x.IsDeleted != 1 && x.AccountUserInvoice.IsDeleted != 1 && x.AccountUserInvoice.SponsorshipCompany.BranchId == BranchId )
                                     .Select(x => x.AccountUserInvoiceId).Distinct().Count();
                var TotalActiveSalesList = await DBContext.ClientInvoiceProject.Where(x => x.Project.SalesExecutiveId == SalesExecutiveId && x.Project.ProjectTypeId == 1 && x.IsDeleted != 1 && x.AccountUserInvoice.IsDeleted != 1 && x.AccountUserInvoice.SponsorshipCompany.BranchId == BranchId ).Select(x => x.AccountUserInvoiceId).Distinct().ToArrayAsync();
                decimal UserActiveSalesList = CompanyTotalSales > 0 ? (UserTotalSales * 100) / CompanyTotalSales : 0;

                var userData = await DBContext.User.Where(x => x.Id == SalesExecutiveId).Include(x => x.BasicDetail).Include(x => x.JobDetailsUser).ThenInclude(x => x.Designation).ToListAsync();

                //Notification Tab start
                var tradeLicenceExpPjt = await DBContext.ProjectDocument.Where(x => prjIds.Contains((long)x.ProjectId) && x.DocumentTypeId == _tradeLicenceDoc
                && x.ExpiryDate.HasValue &&/* x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new { Name = x.Project.ProjectName, x.ExpiryDate }).ToListAsync();
                var tradeLicenceExpClent = await DBContext.UserDocument.Where(x => clientIds.Contains((long)x.UserId) && x.DocumentTypeId == _tradeLicenceDoc
                && x.ExpiryDate.HasValue &&/* x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new { Name = x.User.BasicDetail.IncorporatedName, x.ExpiryDate }).ToListAsync();
                var tradeLicenceExp= tradeLicenceExpPjt.Concat(tradeLicenceExpClent).ToList();
               
                var lpoExpPjt = await DBContext.ProjectDocument.Where(x => prjIds.Contains((long)x.ProjectId) && x.DocumentTypeId == _LPODoc
                    && x.ExpiryDate.HasValue && /*x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new {Name = x.Project.ProjectName, x.ExpiryDate }).ToListAsync();
                var lpoExpClient = await DBContext.UserDocument.Where(x => clientIds.Contains((long)x.UserId) && x.DocumentTypeId == _LPODoc
                    && x.ExpiryDate.HasValue && /*x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new { Name = x.User.BasicDetail.IncorporatedName, x.ExpiryDate }).ToListAsync(); 
                var lpoExp = lpoExpPjt.Concat(lpoExpClient).ToList();

                var agreementExpPjt = await DBContext.ProjectDocument.Where(x => prjIds.Contains((long)x.ProjectId) && x.DocumentTypeId == _AgreementDoc
                    && x.ExpiryDate.HasValue && /*x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new { Name = x.Project.ProjectName, x.ExpiryDate }).ToListAsync();
                var agreementExpClient = await DBContext.UserDocument.Where(x => clientIds.Contains((long)x.UserId) && x.DocumentTypeId == _AgreementDoc
                   && x.ExpiryDate.HasValue && /*x.ExpiryDate.Value.Date >= startDate.Date &&*/ x.ExpiryDate.Value.Date <= endDate.Date).Select(x => new { Name = x.User.BasicDetail.IncorporatedName, x.ExpiryDate }).ToListAsync();
                var agreementExp = agreementExpPjt.Concat(agreementExpClient).ToList();

                //end 

                decimal salesTarget = 0;
                var result = new DashboardViewModel();
                if (userData != null && userData.Count > 0)
                {
                    result.EmployeeName = userData.FirstOrDefault().BasicDetail.FirstName + " " + userData.FirstOrDefault().BasicDetail.MiddleName;
                    result.EmployeeDesignation = (userData.FirstOrDefault().JobDetailsUser.FirstOrDefault()) != null ? ((userData.FirstOrDefault().JobDetailsUser != null && userData.FirstOrDefault().JobDetailsUser.Count > 0 && userData.FirstOrDefault().JobDetailsUser.FirstOrDefault().Designation != null) ?
                        userData.FirstOrDefault().JobDetailsUser.FirstOrDefault().Designation.Name : null) : "";
                    result.EmployeeEmail = userData.FirstOrDefault().BasicDetail.EmailId ?? "";
                    result.EmployeeMobile = userData.FirstOrDefault().BasicDetail.LocalCompanyMobileNo ?? "";
                    result.EmployeePhotoId = userData.FirstOrDefault().BasicDetail.PhotoId ?? null;
                    salesTarget = userData.FirstOrDefault().BasicDetail.SalesTarget.HasValue ? userData.FirstOrDefault().BasicDetail.SalesTarget.Value : 0;
                }
               
                result.OustandingInvoiceAmount = BalanceAmountPr;
                result.SalesExecutiveId = SalesExecutiveId;
                result.LastMonthCustomerCount = PreviousMonthCustomer;
                result.ThisMonthCustomerCount = CurrentMonthCustomer;
                result.CustomerDifferencePercentage = CustomerDiff;
                result.TotalEmployeeCount = EmpCount;

                result.LastMonthTaskCount = PreviousMonthTasks;
                result.ThisMonthTaskCount = CurrentMonthTasks;
                result.TaskDifferencePercentage = TaskDiff;

                result.LastMonthLeadCount = PreviousMonthOpertunity;
                result.ThisMonthLeadCount = CurrentMonthLead;
                result.LeadDifferencePercentage = LeadDiff;

                result.LastMonthOpportunitiesCount = PreviousMonthOpertunity;
                result.ThisMonthOpportunitiesCount = CurrentMonthOpertunity;
                result.OpportunitiesDifferencePercentage = OpertunityDiff;

                result.CrmtaskList = Tasks;
                result.CrmtaskDetailList = TaskDetails;
                result.CurrentMonthProjectsCount = CurrentMonthProjectsCount;
                result.CurrentMonthProject = CurrentMonthProjects;
                result.CurrentMonthClientsCount = UserTotalClients;
                result.CurrentMonthClients = UserTotalClientsArray;
                result.TotalActiveEmployees = totalActiveEmployees;

                result.ActiveClientPercentage = Math.Round(UserTotalActiveClientsPercentage, 2);

                result.ActiveProjectPercentage = Math.Round(UserTotalActiveProjectPercentage, 2);

                result.NocDetails = nocDetailsCount;
                result.ThisMonthMobilizedCount = nocEmpCount;
                result.TotalMobilizedCount = totalNocEmpCount;
                result.ThisMonthDeMobilizedCount = nocDemobEmpCount;
                result.TotalDeMobilizedCount = totalDemobNocEmpCount;

                result.ActiveSalePercentage = Math.Round(UserActiveSalesList, 2);

                result.TotalActiveSales = TotalActiveSalesList;
                result.TotalActiveSalesCount = TotalActiveSalesCount;

                result.CollectedTimeSheetCount = timesheetCollected;
                result.CollectedTimeSheetProjectCount = timesheetCollectedProject;
                result.TotalTimesheetProjectCount = prjIdsCount.Count();
                result.PendingTimeSheetProjectCount = prjIdsCount.Count() > timesheetCollectedProject? prjIdsCount.Count() - timesheetCollectedProject :0;
                result.PendingTimeSheetPercentage = Math.Round(timesheetMissedPercentage, 2);
                result.CollectedTimeSheetPercentage = Math.Round(timesheetCollectedPercentage, 2);
                result.PendingTimeSheetCount = preNocEmpCount > timesheetCollected ? preNocEmpCount - timesheetCollected : 0;
                result.ClientTimesheetsCount = preNocEmpCount;
                result.TimesheetCollectedList = timesheetCollectedList;

                result.SalesTarget = new decimal[] { salesTarget, salesTarget, salesTarget };
                result.InvoicedAmount[0] = secondLastMonthInvAmount.HasValue ? Math.Round(secondLastMonthInvAmount.Value, 2) : 0;
                result.InvoicedAmount[1] = lastMonthInvAmount.HasValue ? Math.Round(lastMonthInvAmount.Value, 2) : 0;
                result.InvoicedAmount[2] = thisMonthInvAmount.HasValue ? Math.Round(thisMonthInvAmount.Value, 2) : 0;
                result.CollectedAmount[0] = 0;// secondLastMonthCollectedAmount.HasValue ? Math.Round(secondLastMonthCollectedAmount.Value, 2) : 0; //temp until invoice fix
                result.CollectedAmount[1] = 0;// lastMonthCollectedAmount.HasValue ? Math.Round(lastMonthCollectedAmount.Value, 2) : 0; //temp until invoice fix
                result.CollectedAmount[2] = 0; // thisMonthCollectedAmount.HasValue ? Math.Round(thisMonthCollectedAmount.Value, 2) : 0; //temp until invoice fix

                //Notification
                result.TradeLicenceNotfCount = tradeLicenceExp.Count();
                result.LPONotfCount = lpoExp.Count();
                result.AgreementNotfCount = agreementExp.Count();

                result.TradeLicenceNotfList = tradeLicenceExp;
                result.LPONotfList = lpoExp;
                result.AgreementNotfList = agreementExp;

                result.LeadNotfCount = CurrentMonthLead;
                result.OpportunityNotfCount = CurrentMonthOpertunity;

                result.LeadNotfList = CurrentMonthLeadList;
                result.OpportunityNotfList = CurrentMonthOpertunityList;

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                       });

                commonDataObject.Results = new JArray() as dynamic;
                commonDataObject.Results.Add(jsonResult);

            }
            catch (Exception ex)
            {
                sucess.Value = "";
                error.Value = ex.Message;
            }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #endregion

		#region Customer Transfer

        [HttpPost("CustomerTransfer")]
        public async Task<IActionResult> CustomerTransfer([FromBody] CustomerTransferRequest request)
		{
			var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty historyId = new JProperty("Id", "");
            try
            {
				var customer = await DBContext.User.Where(x => x.Id == request.CustomerId).FirstOrDefaultAsync();
				if(customer != null)
				{
					var customerDetails = DBContext.BasicDetails.Where(x => x.Id == customer.BasicDetailId.Value).FirstOrDefault();
					if(customerDetails != null){
						var history = new CrmcustomerSalesExecutiveHistory();
						history.CustomerId = request.CustomerId;
						history.SalesExecutiveId = customerDetails.SalesExecutiveId;
						customerDetails.SalesExecutiveId = request.NewSalesExecutiveId;
						customerDetails.IsOwnLead = 0;
						history.Date = request.Date;
						history.LastUpdatedDate = DateTime.UtcNow;
						DBContext.BasicDetails.Update(customerDetails);
						var newHistory = DBContext.CrmcustomerSalesExecutiveHistory.Add(history);
						DBContext.SaveChanges();
						if(newHistory?.Entity?.Id != null){
							historyId.Value = newHistory.Entity.Id;
						}
					}
				}
			}
            catch (Exception ex)
            {
				 sucess.Value = "";
				 error.Value = ex.Message;
			}
            jsonObject.Add(historyId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
		}


        [HttpGet("GetCustomerTransfer/{CustomerId}")]
        public async Task<IActionResult> GetCustomerTransfer( long CustomerId)
		{
			var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty historyId = new JProperty("Id", "");
            try
            {
				var history = await DBContext.CrmcustomerSalesExecutiveHistory
									 	.Where(x => x.CustomerId == CustomerId 
										 			&& x.IsDeleted != 1)
										.Select(x => new {
											x.Id,
											CustomerId = x.CustomerId,
											CustomerName = x.Customer.BasicDetail.IncorporatedName,
											SalesExecutiveId = x.SalesExecutiveId,
											SalesExecutiveCode = x.SalesExecutive.BasicDetail.Code,
											SalesExecutiveName = x.SalesExecutive.BasicDetail.IncorporatedName,
											x.Date,
											x.LastUpdatedDate
										})
										.ToListAsync();
				var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(history, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
				
			}
            catch (Exception ex)
            {
				 sucess.Value = "";
				 error.Value = ex.Message;
			}
            jsonObject.Add(historyId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
		}


        #endregion Customer Transfer

        #region customer Report

        [HttpPost("GetCrmCustomerReport")]
        public async Task<IActionResult> GetCrmCustomerReport([FromBody] CustomerActivityReportRequest request)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                var loginUser = DBContext.User.Where(x => x.Id == request.UserId ).FirstOrDefault();
                //_normalUserRoleRuleId
                var result =  await DBContext.User.Where(x => x.IsDeleted != 1
                                    && request.CustomerIds.Contains(x.BasicDetail.Id)
                                    && (x.CrmleadClient.Where(y => y.Date.Value.Date >= request.FromDate.Date
                                    && y.Date.Value.Date <= request.ToDate.Date).Count() > 0)
                                    && x.BasicDetail.BranchId == request.BranchId && x.UserRoleId == _crmCustomerRoleId
                                    && ((loginUser.UserRoleRuleId == _normalUserRoleRuleId
                                    	? (x.BasicDetail.SalesExecutiveId == request.UserId) 
										: true)))
									.Select(x=> new
                                   {
                                        Id=x.BasicDetail.Id,
                                        CustomerId = x.BasicDetail.Code,
                                        CustomerName = x.BasicDetail.IncorporatedName,
                                        Trn = x.BasicDetail.Trn,
                                        Country = x.BasicDetail.Country.Name,
                                        SalesExecutive = x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName,
                                        Emirates = x.BasicDetail.Emirates.Name,
                                        Currency = x.BasicDetail.Currency.Name,
                                        Website = x.BasicDetail.Website,
                                        SalesExecutiveType = x.BasicDetail.IsOwnLead,
                                        CustomerStatus = x.BasicDetail.StatusId,
                                        CustomerFeedback = x.BasicDetail.Comment.Comment,
                                        ContactTeleNo = x.BasicDetail.TelephoneNo,
                                        ContactMobile = x.BasicDetail.MobileNo,
                                        ContactLocation = x.BasicDetail.Location.Name,
                                        Address = x.BasicDetail.Address,
                                        Email = x.BasicDetail.EmailId,
                                        Fax = x.BasicDetail.FaxNumber,
                                        POBox = x.BasicDetail.Pobox,
                                        RefName = x.UserRefrence.Select(y => new
                                        {
                                            Name = y.Name,
                                            Designation = y.Designation.Name,
                                            Contact = y.ContactNo,
                                            Email = y.Email
                                        }),

                                        Lead = x.CrmleadClient
                                       	.Where(y => y.Date.Value.Date >= request.FromDate.Date && y.Date.Value.Date <= request.ToDate.Date)
                                        .Select(y => new
                                        {
                                            LeadId = y.Id,
                                            LeadNo = y.LeadNo,
                                            LeadDate = y.Date,
                                            LeadStatus = y.LeadStatus.Status,
                                            LeadSource = y.Source.Source,
                                            CompanyType = y.CompanyType.Type,
                                            Location = y.CompanyLocation.Name,
                                            LeadName = y.Client.BasicDetail.IncorporatedName,
                                            LeadOwner = y.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                                            WorkCategory = y.WorkCategory.Name,
                                            ContactPerson = y.ContactPerson,
                                            Emirate = y.Emirates.Name,
                                            Website = y.WebSite,
                                            TelNumber = y.TelNo,
                                            ProjectName = y.ProjectName,
                                            ProjectLocation = y.ProjectLocation.Name,
                                            Comments = y.LeadComments,
                                            Longitude = y.Longitude,
                                            Latitude = y.Latitude,
                                            LeadDetails = y.CrmleadDetails.Select(z => new
                                            {
                                                RateType = z.FAT.Type,
                                                Trade = z.Trade.Name,
                                                Qantity = z.Qty,
                                                Rate = z.Rate,
                                            }),


                                            Task = y.Crmtask.Select(z => new
                                            {
                                                LeadTask = z.Lead.ProjectName,
                                                TaskOwner = z.TaskOwner.BasicDetail.IncorporatedName,
                                                TaskCreatedDate = z.TaskCreatedDate,
                                                TaskType = z.TaskType.Type,
                                                Purpose = z.Purpose.Purpose,
                                                TaskPriority = z.Priority.Priority,
                                                TaskAssignedBy = z.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
                                                TaskAssignedTo = z.TaskAssignedToNavigation.BasicDetail.IncorporatedName,
                                                TaskStatus = z.Status.Status,
                                                TaskCompletedDate = z.TaskCompletedDate,
                                                TaskId = z.CaseId,
                                                TaskUnder = z.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
                                                Project = z.TaskOnId == 1 ? (z.Lead != null ? z.Lead.ProjectName : "") :
                                                                                         (z.TaskOnId == 2 ? (z.Opportunity != null && z.Opportunity.Lead != null ? z.Opportunity.Lead.ProjectName : "") :
                                                                                         (z.Project != null ? z.Project.ProjectName : "")),
                                                Client = z.TaskOnId == 1 ? (z.Lead != null && z.Lead.Client != null && z.Lead.Client.BasicDetail != null ? z.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                                                       (z.TaskOnId == 2 ? (z.Opportunity != null && z.Opportunity.Lead != null && z.Opportunity.Lead.Client != null && z.Opportunity.Lead.Client.BasicDetail != null ? z.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                                                       (z.Project != null && z.Project.Client != null && z.Project.Client.BasicDetail != null ? z.Project.Client.BasicDetail.IncorporatedName : ""))
                                            }),
                                            Opportunity = y.Crmopportunity.Select(z => new
                                            {
												Id = z.Id,
                                                LeadOpportunity = z.Lead.LeadNo,
                                                OpportunityNumber = z.OpportunityNumber,
                                                OpportunityName = z.OpportunityName,
                                                SalesExecutive = z.Lead.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                                                Customer = z.Account.BasicDetail.IncorporatedName,
                                                Source = z.Lead.Source.Source,
                                                ProjectLocation = z.Lead.ProjectLocation.Name,
                                                SponsorshipCompany = z.SponsorShipCompany.Name,
                                                OpportunityClosedDate = (z.Date != null) ? z.Date : null,
                                                OpportunityOwner = (z.Owner != null && z.Owner.BasicDetail != null) ?
                                                     z.Owner.BasicDetail.IncorporatedName : null,
                                                OpportunityComment = z.Comments,
                                                Stage = (z.Status != null) ? z.Status.Status : null,
                                                AccountName = (z.Account != null && z.Account.BasicDetail != null) ?
                                                     z.Account.BasicDetail.IncorporatedName : null,
                                                ContactDetails = z.Lead.CrmleadReference.Select(c => new
                                                {
                                                    ContactPerson = c.Name,
                                                    Designation = c.Designation.Name,
                                                    ContactNo = c.ContactNo,
                                                    EmailId = c.Email
                                                }),
                                                RateTypeDetails = z.Lead.CrmleadDetails.Select(c => new
                                                {
                                                    RateType = c.FAT.Type,
                                                    Trade = c.Trade.Name,
                                                    Quantity = c.Qty,
                                                    Rate = c.Rate
                                                }),
												/* Task =  DBContext.Crmtask.Where(p => p.OpportunityId == z.Id).Select(p => new
													{
														LeadTask = p.Lead.ProjectName,
														TaskOwner = p.TaskOwner.BasicDetail.IncorporatedName,
														TaskCreatedDate = p.TaskCreatedDate,
														TaskType = p.TaskType.Type,
														Purpose = p.Purpose.Purpose,
														TaskPriority = p.Priority.Priority,
														TaskAssignedBy = p.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
														TaskAssignedTo = p.TaskAssignedToNavigation.BasicDetail.IncorporatedName,
														TaskStatus = p.Status.Status,
														TaskCompletedDate = p.TaskCompletedDate,
														TaskId = p.CaseId,
														TaskUnder = p.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
														Project = p.TaskOnId == 1 ? (p.Lead != null ? p.Lead.ProjectName : "") :
																								(p.TaskOnId == 2 ? (p.Opportunity != null && p.Opportunity.Lead != null ? p.Opportunity.Lead.ProjectName : "") :
																								(p.Project != null ? p.Project.ProjectName : "")),
														Client = p.TaskOnId == 1 ? (p.Lead != null && p.Lead.Client != null && p.Lead.Client.BasicDetail != null ? p.Lead.Client.BasicDetail.IncorporatedName : "") :
																							(p.TaskOnId == 2 ? (p.Opportunity != null && p.Opportunity.Lead != null && p.Opportunity.Lead.Client != null && p.Opportunity.Lead.Client.BasicDetail != null ? p.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
																							(p.Project != null && p.Project.Client != null && p.Project.Client.BasicDetail != null ? p.Project.Client.BasicDetail.IncorporatedName : ""))
													}).ToList() */

                                            }) 
                                        }),

                                    }).ToListAsync();
				var opportunities = result.Select(x => x.Lead.Aggregate(new List<long> { }, (all, current) => {
					all.AddRange(current.Opportunity.Select(y => y.Id));
					return all;
				})).Aggregate(new List<long> { }, (all, current) => {
					all.AddRange(current);
					return all;
				}).Distinct().ToList();

				var opportunityTasks = await DBContext.Crmtask.Where(p => opportunities.Contains(p.OpportunityId.Value)).Select(p => new
				{
					LeadTask = p.Lead.ProjectName,
					p.OpportunityId,
					TaskOwner = p.TaskOwner.BasicDetail.IncorporatedName,
					TaskCreatedDate = p.TaskCreatedDate,
					TaskType = p.TaskType.Type,
					Purpose = p.Purpose.Purpose,
					TaskPriority = p.Priority.Priority,
					TaskAssignedBy = p.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
					TaskAssignedTo = p.TaskAssignedToNavigation.BasicDetail.IncorporatedName,
					TaskStatus = p.Status.Status,
					TaskCompletedDate = p.TaskCompletedDate,
					TaskId = p.CaseId,
					TaskUnder = p.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
					Project = p.TaskOnId == 1 ? (p.Lead != null ? p.Lead.ProjectName : "") :
																							  (p.TaskOnId == 2 ? (p.Opportunity != null && p.Opportunity.Lead != null ? p.Opportunity.Lead.ProjectName : "") :
																							  (p.Project != null ? p.Project.ProjectName : "")),
					Client = p.TaskOnId == 1 ? (p.Lead != null && p.Lead.Client != null && p.Lead.Client.BasicDetail != null ? p.Lead.Client.BasicDetail.IncorporatedName : "") :
																						  (p.TaskOnId == 2 ? (p.Opportunity != null && p.Opportunity.Lead != null && p.Opportunity.Lead.Client != null && p.Opportunity.Lead.Client.BasicDetail != null ? p.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
																						  (p.Project != null && p.Project.Client != null && p.Project.Client.BasicDetail != null ? p.Project.Client.BasicDetail.IncorporatedName : ""))
				}).ToListAsync();

				var newResult = result.Select(x => new {
					x.Id,
					x.CustomerId,
					x.CustomerName,
					x.Trn,
					x.Country,
					x.SalesExecutive,
					x.Emirates,
					x.Currency,
					x.Website,
					x.SalesExecutiveType,
					x.CustomerStatus,
					x.CustomerFeedback,
					x.ContactTeleNo,
					x.ContactMobile,
					x.ContactLocation,
					x.Address,
					x.Email,
					x.Fax,
					x.POBox,
					x.RefName,
					Lead = x.Lead.Select(y => new {
						y.LeadId,
						y.LeadNo,
						y.LeadDate,
						y.LeadStatus,
						y.LeadSource,
						y.CompanyType,
						y.Location,
						y.LeadName,
						y.LeadOwner,
						y.WorkCategory,
						y.ContactPerson,
						y.Emirate,
						y.Website,
						y.TelNumber,
						y.ProjectName,
						y.ProjectLocation,
						y.Comments,
						y.Longitude,
						y.Latitude,
						y.LeadDetails,
						y.Task,
						Opportunity = y.Opportunity.Select(z => new {
							z.Id,
							z.LeadOpportunity,
							z.OpportunityNumber,
							z.OpportunityName,
							z.SalesExecutive,
							z.Customer,
							z.Source,
							z.ProjectLocation,
							z.SponsorshipCompany,
							z.OpportunityClosedDate,
							z.OpportunityOwner,
							z.OpportunityComment,
							z.Stage,
							z.AccountName,
							z.ContactDetails,
							z.RateTypeDetails,
							Tasks = opportunityTasks.Where(p => p.OpportunityId == z.Id).ToList()
						}),
					})					
				}).ToList();

				var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(newResult, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(CrmCustomerDataObject);
        }

        #endregion


        #region Customer Activity Report


        [HttpPost("GetCrmCustomerActivityReportbyPage")]
        public async Task<IActionResult> GetCrmCustomerActivityReportbyPage([FromBody] PaginationHeader page)
        {
            var jsonObject = new JObject();
            dynamic CrmCustomerDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty TotalNumberOfRows = new JProperty("TotalNumberOfRows", 0);
            try
            {
                var loginUser = DBContext.User.Where(x => x.Id == page.UserId).FirstOrDefault();
                var predicate = PredicateBuilder.New<User>(x => x.IsDeleted != 1
                                   && x.BasicDetail.BranchId == page.BranchId && x.UserRoleId == _crmCustomerRoleId
                                   && ((loginUser.UserRoleRuleId == _normalUserRoleRuleId
                                   ? (x.BasicDetail.SalesExecutiveId == page.UserId) : true)));
                if (page.GlobalFilter != null && page.GlobalFilter != "")
                {
                    predicate = predicate.And(x => x.BasicDetail.Code.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Trn.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Country.Name.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Emirates.Name.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Currency.Name.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Website.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                    // x.BasicDetail.IsOwnLead.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                    // x.BasicDetail.StatusId.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Comment.Comment.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.TelephoneNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.MobileNo.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Location.Name.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Address.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.EmailId.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.FaxNumber.ToLower().Contains(page.GlobalFilter.ToLower()) ||
                     x.BasicDetail.Pobox.ToLower().Contains(page.GlobalFilter.ToLower()) 
                    );
                }

                if (page.Filters != null)
                    foreach (Filter val in page.Filters)
                    {
                        switch (val.Felid)
                        {
                            case "BasicDetail.Code":
                                predicate = predicate.And(x => x.BasicDetail.Code != null && x.BasicDetail.Code.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.BasicDetail.IncorporatedName != null && x.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Trn":
                                predicate = predicate.And(x => x.BasicDetail.Trn != null && x.BasicDetail.Trn.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Country.Name":
                                predicate = predicate.And(x => x.BasicDetail.Country != null && x.BasicDetail.Country.Name.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.SalesExecutive.BasicDetail.IncorporatedName":
                                predicate = predicate.And(x => x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName != null && x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Emirates.Name":
                                predicate = predicate.And(x => x.BasicDetail.Emirates.Name != null && x.BasicDetail.Emirates.Name.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Currency.Name":
                                predicate = predicate.And(x => x.BasicDetail.Currency.Name != null && x.BasicDetail.Currency.Name.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Website":
                                predicate = predicate.And(x => x.BasicDetail.Website != null && x.BasicDetail.Website.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.IsOwnLead":
                                predicate = predicate.And(x => x.BasicDetail.IsOwnLead != null && x.BasicDetail.IsOwnLead == Convert.ToInt64(val.Value));
                                break;
                            case "BasicDetail.StatusId":
                                predicate = predicate.And(x => x.BasicDetail.StatusId != null && x.BasicDetail.StatusId == Convert.ToInt64(val.Value));
                                break;
                            case "BasicDetail.Comment.Comment":
                                predicate = predicate.And(x => x.BasicDetail.Comment.Comment != null && x.BasicDetail.Comment.Comment.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.TelephoneNo":
                                predicate = predicate.And(x => x.BasicDetail.TelephoneNo != null && x.BasicDetail.TelephoneNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.MobileNo":
                                predicate = predicate.And(x => x.BasicDetail.MobileNo != null && x.BasicDetail.MobileNo.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Location.Name":
                                predicate = predicate.And(x => x.BasicDetail.Location.Name != null && x.BasicDetail.Location.Name.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Address":
                                predicate = predicate.And(x => x.BasicDetail.Address != null && x.BasicDetail.Address.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.EmailId":
                                predicate = predicate.And(x => x.BasicDetail.EmailId != null && x.BasicDetail.EmailId.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.FaxNumber":
                                predicate = predicate.And(x => x.BasicDetail.FaxNumber != null && x.BasicDetail.FaxNumber.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "BasicDetail.Pobox":
                                predicate = predicate.And(x => x.BasicDetail.Pobox != null && x.BasicDetail.Pobox.ToLower().Contains(val.Value.ToLower()));
                                break;
                            case "UserRefrence.Name":
                                predicate = predicate.And(x => x.UserRefrence.Count(y => y.Name != null && y.Name.ToLower().Contains(val.Value.ToLower())) > 0);
                                break;
                            case "UserRefrence.Designation.Name":
                                predicate = predicate.And(x => x.UserRefrence.Count(y => y.Designation.Name != null && y.Designation.Name.ToLower().Contains(val.Value.ToLower())) > 0);
                                break;
                            case "UserRefrence.ContactNo":
                                predicate = predicate.And(x => x.UserRefrence.Count(y => y.ContactNo != null && y.ContactNo.ToLower().Contains(val.Value.ToLower())) > 0);
                                break;
                            case "UserRefrence.Email":
                                predicate = predicate.And(x => x.UserRefrence.Count(y => y.Email != null && y.Email.ToLower().Contains(val.Value.ToLower())) > 0);
                                break;

                        }
                    }

                var result = await DBContext.User.Where(predicate)
                                          .Skip(page.StartIndex)
                                          .Take(page.NoOfRows)
                                          .Select(x => new
                                          {
                                              Id = x.BasicDetail.Id,

                                              CustomerId = x.BasicDetail.Code,
                                       CustomerName = x.BasicDetail.IncorporatedName,
                                       Trn = x.BasicDetail.Trn,
                                       Country = x.BasicDetail.Country.Name,
                                       SalesExecutive = x.BasicDetail.SalesExecutive.BasicDetail.IncorporatedName,
                                       Emirates = x.BasicDetail.Emirates.Name,
                                       Currency = x.BasicDetail.Currency.Name,
                                       Website = x.BasicDetail.Website,
                                       SalesExecutiveType = x.BasicDetail.IsOwnLead,
                                       CustomerStatus = x.BasicDetail.StatusId,
                                       CustomerFeedback = x.BasicDetail.Comment.Comment,
                                       ContactTeleNo = x.BasicDetail.TelephoneNo,
                                       ContactMobile = x.BasicDetail.MobileNo,
                                       ContactLocation = x.BasicDetail.Location.Name,
                                       Address = x.BasicDetail.Address,
                                       Email = x.BasicDetail.EmailId,
                                       Fax = x.BasicDetail.FaxNumber,
                                       POBox = x.BasicDetail.Pobox,
                                       RefName = x.UserRefrence.Select(y => new
                                       {
                                           Name = y.Name,
                                           Designation = y.Designation.Name,
                                           Contact = y.ContactNo,
                                           Email = y.Email
                                       }),
                                       Lead = x.CrmleadClient.Select(y => new
                                       {
                                           LeadId = y.Id,
                                           LeadNo = y.LeadNo,
                                           LeadDate = y.Date,
                                           LeadStatus = y.LeadStatus.Status,
                                           LeadSource = y.Source.Source,
                                           CompanyType = y.CompanyType.Type,
                                           Location = y.CompanyLocation.Name,
                                           LeadName = y.Client.BasicDetail.IncorporatedName,
                                           LeadOwner = y.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                                           WorkCategory = y.WorkCategory.Name,
                                           ContactPerson = y.ContactPerson,
                                           Emirate = y.Emirates.Name,
                                           Website = y.WebSite,
                                           TelNumber = y.TelNo,
                                           ProjectName = y.ProjectName,
                                           ProjectLocation = y.ProjectLocation.Name,
                                           Comments = y.LeadComments,
                                           Longitude = y.Longitude,
                                           Latitude = y.Latitude,
                                           LeadDetails = y.CrmleadDetails.Select(z => new
                                           {
                                               RateType = z.FAT.Type,
                                               Trade = z.Trade.Name,
                                               Qantity = z.Qty,
                                               Rate = z.Rate,
                                           }),


                                           Task = y.Crmtask.Select(z => new
                                           {
                                               LeadTask = z.Lead.ProjectName,
                                               TaskOwner = z.TaskOwner.BasicDetail.IncorporatedName,
                                               TaskCreatedDate = z.TaskCreatedDate,
                                               TaskType = z.TaskType.Type,
                                               Purpose = z.Purpose.Purpose,
                                               TaskPriority = z.Priority.Priority,
                                               TaskAssignedBy = z.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
                                               TaskAssignedTo = z.TaskAssignedToNavigation.BasicDetail.IncorporatedName,
                                               TaskStatus = z.Status.Status,
                                               TaskCompletedDate = z.TaskCompletedDate,
                                               TaskId = z.CaseId,
                                               TaskUnder = z.TaskAssignedByNavigation.BasicDetail.IncorporatedName,
                                               Project = z.TaskOnId == 1 ? (z.Lead != null ? z.Lead.ProjectName : "") :
                                                                                        (z.TaskOnId == 2 ? (z.Opportunity != null && z.Opportunity.Lead != null ? z.Opportunity.Lead.ProjectName : "") :
                                                                                        (z.Project != null ? z.Project.ProjectName : "")),
                                               Client = z.TaskOnId == 1 ? (z.Lead != null && z.Lead.Client != null && z.Lead.Client.BasicDetail != null ? z.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                                                      (z.TaskOnId == 2 ? (z.Opportunity != null && z.Opportunity.Lead != null && z.Opportunity.Lead.Client != null && z.Opportunity.Lead.Client.BasicDetail != null ? z.Opportunity.Lead.Client.BasicDetail.IncorporatedName : "") :
                                                                                      (z.Project != null && z.Project.Client != null && z.Project.Client.BasicDetail != null ? z.Project.Client.BasicDetail.IncorporatedName : ""))
                                           }),
                                           Opportunity = y.Crmopportunity.Select(z => new
                                           {
                                               LeadOpportunity = z.Lead.LeadNo,
                                               OpportunityNumber = z.OpportunityNumber,
                                               OpportunityName = z.OpportunityName,
                                               SalesExecutive = z.Lead.AssignedSalesExecutive.BasicDetail.IncorporatedName,
                                               Customer = z.Account.BasicDetail.IncorporatedName,
                                               Source = z.Lead.Source.Source,
                                               ProjectLocation = z.Lead.ProjectLocation.Name,
                                               SponsorshipCompany = z.SponsorShipCompany.Name,
                                               OpportunityClosedDate = (z.Date != null) ? z.Date : null,
                                               OpportunityOwner = (z.Owner != null && z.Owner.BasicDetail != null) ?
                                                    z.Owner.BasicDetail.IncorporatedName : null,
                                               OpportunityComment = z.Comments,
                                               Stage = (z.Status != null) ? z.Status.Status : null,
                                               AccountName = (z.Account != null && z.Account.BasicDetail != null) ?
                                                    z.Account.BasicDetail.IncorporatedName : null,
                                               ContactDetails = z.Lead.CrmleadReference.Select(c => new
                                               {
                                                   ContactPerson = c.Name,
                                                   Designation = c.Designation.Name,
                                                   ContactNo = c.ContactNo,
                                                   EmailId = c.Email
                                               }),
                                               RateTypeDetails = z.Lead.CrmleadDetails.Select(c => new
                                               {
                                                   RateType = c.FAT.Type,
                                                   Trade = c.Trade.Name,
                                                   Quantity = c.Qty,
                                                   Rate = c.Rate
                                               })

                                           })
                                       }),

                                   }).ToListAsync();

                if (page.StartIndex <= 1)
                {
                    TotalNumberOfRows.Value = DBContext.User.Where(predicate).Count();
                }


                result = result.OrderByDescending(x => x.CustomerId).Skip(page.StartIndex).Take(page.NoOfRows).ToList();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                CrmCustomerDataObject.Results = new JArray() as dynamic;
                CrmCustomerDataObject.Results.Add(jsonResult);

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            jsonObject.Add(TotalNumberOfRows);
            return Ok(CrmCustomerDataObject);
        }




        #endregion

        #region get all customer, opportunity, task, lead

        [HttpGet("GetAllCrmCompanyAndLead/{BranchId}/{UserId}")]
        public async Task<IActionResult> GetAllCrmCompanyAndLead(int BranchId,long UserId)
        {
            var jsonObject = new JObject();
            dynamic commonDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var loginUser = DBContext.User.Where(x => x.Id == UserId).FirstOrDefault();
                var result = await DBContext.User
                                            .Where(x => x.UserRoleId == _crmCustomerRoleId
                                                        && x.IsDeleted != 1
                                                        && x.BasicDetail.BranchId == BranchId
                                                         && x.BasicDetail.BranchId == BranchId && x.UserRoleId == _crmCustomerRoleId
                                    && ((loginUser.UserRoleRuleId == _normalUserRoleRuleId
                                    ? (x.BasicDetail.SalesExecutiveId == UserId) : true))
                                                        )
                                            .Select(x => new {
                                                CustomerId = x.BasicDetail.Id,
                                                x.BasicDetail.IncorporatedName,
                                                LeadDate = x.CrmleadClient.Where(x=>x.Date != null).OrderBy(x=>x.Date).FirstOrDefault().Date,
                                                Code = x.BasicDetail.Code
                                            })
                                            .ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

                commonDataObject.Results = new JArray() as dynamic;
                commonDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
                sucess.Value = ""; error.Value = ex.Message;
            }
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(commonDataObject);
        }

        [HttpGet("GetAllCrmLeads")]
        public async Task<IActionResult> GetAllCrmLeads()
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = DBContext.CrmleadSource.Where(x => x.IsDeleted != 1).Select(x => new {
                    x.Id,
                    x.Source}).ToList();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }

        [HttpGet("GetCrmTasks")]
        public async Task<IActionResult> GetCrmTasks()
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = DBContext.CrmtaskType.Where(x => x.IsDeleted != 1).Select(x =>new {
                    x.Id,
                    x.Type
                }).ToList();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }

        [HttpGet("GetCrmOpportunities")]
        public async Task<IActionResult> GetCrmOpportunities()
        {
            var jsonObject = new JObject();
            dynamic resultObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = DBContext.Crmopportunity.Where(x => x.IsDeleted != 1).Select(x =>new { 
                    x.OpportunityNumber,
                x.OpportunityName
                }).ToList();

                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                resultObject.Results = new JArray() as dynamic;
                resultObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message != null)
                    error.Value = ex.InnerException.Message;
                else
                    error.Value = ex.Message;
                sucess.Value = "";
            }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(resultObject);
        }

      


        #endregion

		#region Special Day Greetings
			 
        [HttpPost("SpecialDayGreetings")]
        public async Task<IActionResult> SpecialDayGreetings([FromBody] SpecialDayGreetings specialDayGreetings)
		{
			var jsonObject = new JObject();
            dynamic responce = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
				string WorldstarEmailUserName = "" ;
                string WorldstarEmailPassword = "" ;

				switch (specialDayGreetings.BranchId)
				{
					case 1:
                    	WorldstarEmailUserName = this.Settings.WorldstarSharjaEmailUserName;					
                    	WorldstarEmailPassword = this.Settings.WorldstarSharjaEmailPassword;
						break;
					case 2:
                    	WorldstarEmailUserName = this.Settings.WorldstarDXBEmailUserName;					
                    	WorldstarEmailPassword = this.Settings.WorldstarDXBEmailPassword;
						break;
					case 3:
                    	WorldstarEmailUserName = this.Settings.WorldstarAUHEmailUserName;					
                    	WorldstarEmailPassword = this.Settings.WorldstarAUHEmailPassword;
						break;
					default:
						WorldstarEmailUserName = this.Settings?.TestUserName ?? "";
 						WorldstarEmailPassword = this.Settings?.TestPassword ?? "";
						break;
				}
				if(specialDayGreetings.AttachmentId != null)
				{
					var attachment = await DBContext.Attachment.Where(x => x.Id == specialDayGreetings.AttachmentId).FirstOrDefaultAsync();
					specialDayGreetings.AttachmentPath = attachment.FilePath;
				}
				if(specialDayGreetings.AttachmentId != null || specialDayGreetings.Content != null)
				{
					var mail = new EmailService().SendSpecialDayGreetings(specialDayGreetings,this._environment.ContentRootPath, WorldstarEmailUserName, WorldstarEmailPassword, this.Settings.EmailServerName);
				}
			}
            catch (Exception ex)
            {
				 sucess.Value = "";
				 error.Value = ex.Message;
			}
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(responce);
		}

		#endregion

		#region Customer Evaluation
			 
		[HttpGet("GetCustomerEvaluation/{Id}")]
        public async Task<IActionResult> GetCustomerEvaluation(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.CustomerEvaluation
											 .Where(x => x.Id == Id && x.IsDeleted != 1)
											 .Select(x => new {
												 x.Id,
												 x.CustomerId,
												 x.IsDeleted,
												 Customer = new {
													 x.Customer.Id,
													 x.Customer.BasicDetail.IncorporatedName
												 },
												 CustomerEvaluationDetails = x.CustomerEvaluationDetails
												 							  .Where(x => x.IsDeleted != 1)
																			  .Select(y => new {
																				  y.Id,
																				  y.QuestionId,
																				  y.AnswerId,
																			  })
											 })
											 .ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
             catch (Exception ex)
            {
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpGet("GetAllCustomerEvaluation")]
        public async Task<IActionResult> GetAllCustomerEvaluation()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.CustomerEvaluation
											 .Where(x =>  x.IsDeleted != 1)
											 .Select(x => new {
												 x.Id,
												 x.CustomerId,
												 x.IsDeleted,
												 Customer = new {
													 x.Customer.Id,
													 x.Customer.BasicDetail.IncorporatedName
												 },
												 CustomerEvaluationDetails = x.CustomerEvaluationDetails
												 							  .Where(x => x.IsDeleted != 1)
																			  .Select(y => new {
																				  y.Id,
																				  y.QuestionId,
																				  y.AnswerId,
																			  })
											 })
											 .ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpPost("InsertCustomerEvaluation")]
        public async Task<IActionResult> InsertCustomerEvaluation([FromBody] CustomerEvaluation CustomerEvaluation)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CustomerEvaluationId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CustomerEvaluation.Update(CustomerEvaluation);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CustomerEvaluationId.Value = newUser.Entity.Id;
                }
                else
                    CustomerEvaluationId.Value = 0;


            }
            catch (Exception ex)
            { 
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CustomerEvaluationId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpPost("UpdateCustomerEvaluation")]
        public async Task<IActionResult> UpdateCustomerEvaluation([FromBody] CustomerEvaluation CustomerEvaluation)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CustomerEvaluation.Update(CustomerEvaluation);
                DBContext.SaveChanges();
            }
            catch (Exception ex) 
			{
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        [HttpPost("DeleteCustomerEvaluation")]
        public async Task<IActionResult> DeleteCustomerEvaluation([FromBody] CustomerEvaluation CustomerEvaluation)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CustomerEvaluation.IsDeleted = 1;
                DBContext.CustomerEvaluation.Update(CustomerEvaluation);
                DBContext.SaveChanges();
            }
            catch (Exception ex) 
			{
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

		#endregion

		#region Customer Evaluation Questionnaire

		[HttpGet("GetQuestionnaire/{Id}")]
        public async Task<IActionResult> GetQuestionnaire(long Id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.CustomerEvaluationQuestionnaire
                    						 .Where(x => x.Id == Id && x.IsDeleted != 1)
											 .Select(x => new {
												 x.Id,
												 x.Question,
												 x.IsDeleted,
												 CustomerEvaluationAnswer = x.CustomerEvaluationAnswer
												 							 .Where(y => y.IsDeleted != 1)
																			 .Select( y => new {
																				 y.Id,
																				 y.Answer,
																				 y.Score,
																				 y.IsDeleted,
																				 y.QuestionId,
																				 _isUsed = y.CustomerEvaluationDetails.Where(z => z.IsDeleted != 1).Count() > 0
																			 }),
												_isUsed = x.CustomerEvaluationDetails.Where(z => z.IsDeleted != 1).Count() > 0
											 })
											 .ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpGet("GetAllQuestionnaire")]
        public async Task<IActionResult> GetAllQuestionnaire()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.CustomerEvaluationQuestionnaire
                    						 .Where(x => x.IsDeleted != 1)
											 .Select(x => new {
												 x.Id,
												 x.Question,
												 x.IsDeleted,
												 CustomerEvaluationAnswer = x.CustomerEvaluationAnswer
												 							 .Where(y => y.IsDeleted != 1)
																			 .Select( y => new {
																				 y.Id,
																				 y.Answer,
																				 y.Score,
																				 y.IsDeleted,
																				 y.QuestionId,
																				 _isUsed = y.CustomerEvaluationDetails.Where(z => z.IsDeleted != 1).Count() > 0
																			 }),
												_isUsed = x.CustomerEvaluationDetails.Where(z => z.IsDeleted != 1).Count() > 0
											 })
											 .ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            {
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpPost("InsertQuestionnaire")]
        public async Task<IActionResult> InsertQuestionnaire([FromBody] CustomerEvaluationQuestionnaire CustomerEvaluationQuestionnaire)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty CustomerEvaluationQuestionnaireId = new JProperty("Id", "");
            try
            {
                var newUser = DBContext.CustomerEvaluationQuestionnaire.Update(CustomerEvaluationQuestionnaire);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.Id > 0)
                {
                    CustomerEvaluationQuestionnaireId.Value = newUser.Entity.Id;
                }
                else
                    CustomerEvaluationQuestionnaireId.Value = 0;


            }
            catch (Exception ex)
            {
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(CustomerEvaluationQuestionnaireId);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

        [HttpPost("UpdateQuestionnaire")]
        public async Task<IActionResult> UpdateQuestionnaire([FromBody] CustomerEvaluationQuestionnaire CustomerEvaluationQuestionnaire)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.CustomerEvaluationQuestionnaire.Update(CustomerEvaluationQuestionnaire);
                DBContext.SaveChanges();
            }
            catch (Exception ex) 
			{
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
		
        [HttpPost("DeleteQuestionnaire")]
        public async Task<IActionResult> DeleteQuestionnaire([FromBody] CustomerEvaluationQuestionnaire CustomerEvaluationQuestionnaire)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                CustomerEvaluationQuestionnaire.IsDeleted = 1;
                DBContext.CustomerEvaluationQuestionnaire.Update(CustomerEvaluationQuestionnaire);
                DBContext.SaveChanges();
            }
            catch (Exception ex) 
			{
				sucess.Value = ""; 
				error.Value = ex.Message; 
			}
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        #endregion





        [HttpGet("Getfeedback/{id}")]
        public async Task<IActionResult> Getfeedback(int id)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await (DBContext.feedback
                    .Where(x => x.id == id)).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }



        [HttpGet("GetAllfeedback")]
        public async Task<IActionResult> GetAllfeedback()
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                var result = await DBContext.feedback
                    .Where(x => x.IsDeleted != 1).ToListAsync();
                var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                masterDataObject.Results = new JArray() as dynamic;
                masterDataObject.Results.Add(jsonResult);
            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            //dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }




        [HttpPost("Updatefeedback")]
        public async Task<IActionResult> Updatefeedback([FromBody] feedback feedback)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                DBContext.feedback.Update(feedback);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }
        [HttpPost("Deletefeedback")]
        public async Task<IActionResult> Deletefeedback([FromBody] feedback feedback)
        {
            var jsonObject = new JObject();
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            try
            {
                feedback.IsDeleted = 1;
                DBContext.feedback.Update(feedback);
                DBContext.SaveChanges();
            }
            catch (Exception ex) { sucess.Value = ""; error.Value = ex.Message; }
            dynamic ItemObject = jsonObject;
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(ItemObject);
        }

        [HttpPost("Insertfeedback")]
        public async Task<IActionResult> Insertfeedback([FromBody] feedback feedback)
        {
            var jsonObject = new JObject();
            dynamic masterDataObject = jsonObject;
            JProperty error = new JProperty("ErrorMessage", "");
            JProperty sucess = new JProperty("SuccessMessage", "Sucess");
            JProperty feedbackid = new JProperty("id", "");
            try
            {
                var newUser = DBContext.feedback.Update(feedback);
                DBContext.SaveChanges();
                if (newUser != null && newUser.Entity != null && newUser.Entity.id > 0)
                {
                    feedbackid.Value = newUser.Entity.id;
                }
                else
                    feedbackid.Value = 0;


            }
            catch (Exception ex)
            { sucess.Value = ""; error.Value = ex.Message; }
            dynamic SupplierObject = jsonObject;
            jsonObject.Add(feedbackid);
            jsonObject.Add(error);
            jsonObject.Add(sucess);
            return Ok(masterDataObject);
        }

    }
}

