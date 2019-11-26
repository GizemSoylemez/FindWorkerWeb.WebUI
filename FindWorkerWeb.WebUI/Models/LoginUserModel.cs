using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class LoginUserModel
    {
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }

    }
}
