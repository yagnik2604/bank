using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class TransferModel
    {
        public long from_account_id { get; set; }
        public long to_account_id { get; set; }
        public long user_id { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }

    }
}