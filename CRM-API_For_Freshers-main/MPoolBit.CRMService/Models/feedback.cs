using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class feedback
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
        public short? IsDeleted { get; set; }
    }
}
