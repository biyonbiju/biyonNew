using System;
namespace MPoolBit.CRMService.Helper
{
    public class CustomerTransferRequest
    {
		public long CustomerId { get; set; }
		public long NewSalesExecutiveId { get; set; }
        public DateTime Date { get; set; }

	}
}
