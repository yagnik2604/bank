using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class RegisterModel
    {

        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}