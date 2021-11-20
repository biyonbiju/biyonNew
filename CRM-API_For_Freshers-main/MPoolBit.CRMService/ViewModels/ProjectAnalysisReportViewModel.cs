using MPoolBit.CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class ProjectAnalysisReportViewModel
    {
        public DateTime? Date { get; set; }
        public bool IsSelf { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocationX { get; set; }
        public string CompanyLocationY { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocationX { get; set; }
        public string ProjectLocationY { get; set; }
        public string ProjectType { get; set; }
        public string ClientName { get; set; }
        public string PaymentTerms { get; set; }
        public string GuaranteeCheque { get; set; }
        public string ProjectDuration { get; set; }
        public string HoursPerDay { get; set; }
        public string FridayOrHolidaysWorkingStatus { get; set; }
        public List<CrmleadReference> ContactDetails { get; set; }
        public List<CrmleadDetails> ManpowerDetails { get; set; }
        public List<long> Attachments { get; set; }
        public string Remarks { get; set; }
        public string SalesExecutive { get; set; }
        public string ProcurementOperationsManager { get; set; }
        public string ExecutiveManager { get; set; }

    }
}
