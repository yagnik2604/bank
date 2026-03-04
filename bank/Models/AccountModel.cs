using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class AccountModel
    {
        public long user_id { get; set; }
        public string account_type { get; set; }
        public string currency { get; set; }

    }
}