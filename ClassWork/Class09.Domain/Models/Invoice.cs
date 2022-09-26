using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class09.Domain.Models
{
    public class Invoice
    {
        public string ClientName { get; set; }
        public long InvoiceId { get; set; }
        public byte[] InvoiceDate { get; set; }
        public string Country { get; set; }
    }
}
