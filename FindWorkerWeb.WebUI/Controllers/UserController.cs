using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Helper;
using FindWorkerWeb.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Profile([FromForm] CvModel cv)
        {
          
            return View();
        }

        public IActionResult Cv1()
        {
            return View();
        }
        public IActionResult Cv2()
        {
            return View();
        }
        public IActionResult Cv3()
        {
            return View();
        }
        public IActionResult ExampleCv1()
        {
            return View();
        }
        public IActionResult ExampleCv2()
        {
            return View();
        }
        public IActionResult ExampleCv3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CVData([FromForm] CvModel cv)
        {
            
           
            var response = ApiHelper.Post("CvData/AddCv", cv);
           
            return Redirect("Home/AnaSayfa");
        }
    }
}