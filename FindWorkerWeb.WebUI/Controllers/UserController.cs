﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Models;
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
      
        public IActionResult Profile()
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
    }
}