using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Helper;
using FindWorkerWeb.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }

        public IActionResult CvList()
        {

            var response = ApiHelper.Get<CvModel>("CvData/GetCvData",model:null);
            return View("CvList",response);
        }
    }

}