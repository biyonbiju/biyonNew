using MPoolBit.CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            SalesTarget = new decimal[3];
            InvoicedAmount = new decimal[3];
            CollectedAmount = new decimal[3];
        }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeMobile { get; set; }
        public long? EmployeePhotoId { get; set; }
        public long TotalInvoiceAmount { get; set; }
        public decimal? OustandingInvoiceAmount { get; set; }

        public long LastMonthCustomerCount { get; set; }
        public long ThisMonthCustomerCount { get; set; }
        public long CustomerCountDifference { get; set; }
        public decimal CustomerDifferencePercentage { get; set; }

        public long LastMonthTaskCount { get; set; }
        public long ThisMonthTaskCount { get; set; }
        public decimal CurrentMonthClientsCount { get; set; }
        public long TotalActiveEmployees { get; set; }
        public decimal TotalActiveSalesCount { get; set; }
        public long CurrentMonthProjectsCount { get; set; }
        public long SalesExecutiveId { get; set; }
        public long[] CurrentMonthProject { get; set; }
        public long[] TimesheetCollectedList { get; set; }
        public long?[] TotalActiveSales { get; set; }
        public long?[] CurrentMonthClients { get; set; }
        public long TaskCountDifference { get; set; }
        public decimal TaskDifferencePercentage { get; set; }

        public long LastMonthLeadCount { get; set; }
        public long ThisMonthLeadCount { get; set; }
        public long LeadCountDifference { get; set; }
        public decimal LeadDifferencePercentage { get; set; }

        public long LastMonthOpportunitiesCount { get; set; }
        public long ThisMonthOpportunitiesCount { get; set; }
        public long OpportunitiesCountDifference { get; set; }
        public decimal OpportunitiesDifferencePercentage { get; set; }

        public Crmtask[] CrmtaskList { get; set; }
        public CrmtaskDetail[] CrmtaskDetailList { get; set; }
        public long TotalClientCount { get; set; }
        public long ActiveClientCount { get; set; }
        public decimal ActiveClientPercentage { get; set; }
        public decimal InactiveClientPercentage { get; set; }

        public long TotalProjectCount { get; set; }
        public long ActiveProjectCount { get; set; }
        public decimal ActiveProjectPercentage { get; set; }
        public decimal InactiveProjectPercentage { get; set; }

        public long TotalSaleCount { get; set; }
        public long ActiveSaleCount { get; set; }
        public decimal ActiveSalePercentage { get; set; }
        public decimal InactiveSalePercentage { get; set; }

        public long ThisMonthMobilizedCount { get; set; }
        public long TotalMobilizedCount { get; set; }
        public long TotalEmployeeCount { get; set; }
        public long NocDetails { get; set; }
        public long ClientTimesheetsCount { get; set; }
        public long ThisMonthDeMobilizedCount { get; set; }
        public long TotalDeMobilizedCount { get; set; }

        public long TotalTimeSheetCount { get; set; }
        public long CollectedTimeSheetCount { get; set; }
        public long CollectedTimeSheetProjectCount { get; set; }
        public long TotalTimesheetProjectCount { get; set; }
        public long PendingTimeSheetProjectCount { get; set; }
        public long PendingTimeSheetCount { get; set; }
        public decimal CollectedTimeSheetPercentage { get; set; }
        public decimal PendingTimeSheetPercentage { get; set; }
        public decimal[] SalesTarget { get; set; }
        public decimal[] InvoicedAmount { get; set; }
        public decimal[] CollectedAmount { get; set; }
        public int TradeLicenceNotfCount { get; set; }
        public int LPONotfCount { get; set; }
        public int AgreementNotfCount { get; set; }
        public int LeadNotfCount { get; set; }
        public int OpportunityNotfCount { get; set; }
        public object TradeLicenceNotfList { get; set; }
        public object LPONotfList { get; set; }
        public object AgreementNotfList { get; set; }
        public object LeadNotfList { get; set; }
        public object OpportunityNotfList { get; set; }
    }
}
