﻿using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocTradeReason
    {
        public NocTradeReason()
        {
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
    }
}
