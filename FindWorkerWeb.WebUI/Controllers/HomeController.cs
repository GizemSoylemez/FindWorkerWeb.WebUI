using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Email")) && String.IsNullOrEmpty(HttpContext.Session.GetString("CompanyEmail")))
            {
                return Redirect("/Home/AnaSayfa");
            }
            return View();
        }
        public IActionResult AnaSayfa()
        {
            return View();
        }

        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}