using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class ContactModelProperty
    {
        public string Decription { get; set; }
        public string ContactName { get; set; }
        public int UserId { get; set; }

    }

public class ContactModel
    {    
        public List<string> Decription { get; set; }
        public List<string> ContactName { get; set; }
        public int UserId { get; set; }


    }
}
