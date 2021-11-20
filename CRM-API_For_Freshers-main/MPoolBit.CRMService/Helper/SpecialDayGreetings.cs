using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Helper
{
	public class SpecialDayGreetings
	{
		public long BranchId { get; set; }
		public long? AttachmentId { get; set; }
		public string AttachmentPath { get; set; }
		public string Subject { get; set; }
		public string Content { get; set; }
		public List<SpecialDayGreetingsCustomer> CustomerEmails { get; set; }

	}

	public class SpecialDayGreetingsCustomer{
		public string Name { get; set; }
		public string Email { get; set; }

	}
}
