using System;
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
        private UserManager<UserModel> usermanager;
        public UserController(UserManager<UserModel> _userManager)
        {
            usermanager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await usermanager.GetUserAsync(User);
            ViewBag.user = user;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Profile(string username,string name, string password, string surname, string email, int phonenumber, string photo)
        {
            var user = await usermanager.GetUserAsync(User);
            user.Email = email;
            user.PhoneNumber = phonenumber.ToString();
            user.UserName = username;
            user.Name = name;
            user.Password = password;
            user.Surname = surname;
            user.ProfilePhoto = photo;

            var result = await usermanager.UpdateAsync(user);
            if(!result.Succeeded)
            {
                return Redirect ("/");
            }
            ViewBag.user = user;
            return View();
        }
    }
}