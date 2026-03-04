using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class AddMoneyModel
    {
        public long account_id { get; set; }
        public decimal amount { get; set; }
        public long user_id { get; set; }

    }
}