using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class CompanyModel
    {
        public string CompanyEmail { get; set; }
        
        [Required, Compare(nameof(Password))]
        public string Password { get; set; }
        public string CompanyName { get; set; }
       
    }
}
