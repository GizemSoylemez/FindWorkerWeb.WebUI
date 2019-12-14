using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Helper;
using FindWorkerWeb.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class CvdataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}