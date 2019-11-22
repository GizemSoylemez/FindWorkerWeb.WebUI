using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class RegisterModel
    {
        public UserModel user { get; set; }
        public CompanyModel company { get; set; }
    }
}
