using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Helper;
using FindWorkerWeb.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult UserPanel()
        {
            return View();
        }

        public IActionResult CompanyPanel()
        {
            return View();
        }




        [HttpPost]
        public IActionResult Register([FromForm]UserModel user)
        {

            //var client = new RestClient("http://192.168.1.8/api/");
            //var request = new RestRequest("Register/RegisterUser", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddJsonBody(user);
            //IRestResponse response = client.Execute(request);
            //var content = response.Content;
            //var response=ApiHelper.Post("Register/RegisterUser", user);


            if (ModelState.IsValid)
            {
                var response = ApiHelper.Post("Register/RegisterUser", user);

                return Redirect("/");
            }

            return View();
        }
        public IActionResult CompanyRegister([FromForm] CompanyModel company)
        {
            //var client = new RestClient("http://192.168.1.8/api/");
            //var request = new RestRequest("Register/RegisterCompany", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddJsonBody(company);
            //IRestResponse response = client.Execute(request);
            //var response = ApiHelper.Post("Register/RegisterCompany", company);


            if (ModelState.IsValid)
            {
                var response = ApiHelper.Post("Register/RegisterCompany", company);
            }

            return View("Register");
        }


       

        [HttpPost]
        public IActionResult Login([FromForm] UserModel user)
        {

            //var client = new RestClient("http://192.168.1.8/api/");
            //var request = new RestRequest("Auth/UserLogin", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddJsonBody(user);
            //IRestResponse response = client.Execute(request);
            //var content = response.Content;
            //var data = JsonConvert.DeserializeObject<Token>(content);
            Token usertoken = (Token)ApiHelper.Post<Token>("Auth/UserLogin", user);

            if (usertoken.token != null )
            {
                //var request1 = new RestRequest("User/GetLoginUser", Method.GET);
                //request1.AddHeader("Content-Type", "application/json");
                //request1.AddHeader("Authorization", "bearer " + data.token);
                //IRestResponse response1 = client.Execute(request1);
                ////var content1 = response1.Content;
                //var data1 = JsonConvert.DeserializeObject<LoginUserModel>(content1);

                var userdata = (LoginUserModel)ApiHelper.Get<LoginUserModel>("User/GetLoginUser", token: usertoken.token);
                HttpContext.Session.SetString("Email", userdata.Email);
                HttpContext.Session.SetString("RoleId", userdata.RoleId.ToString());
                HttpContext.Session.SetString("Name", userdata.Name);

                return RedirectToAction("UserPanel");
            }
            //var request2 = new RestRequest("Auth/CompanyLogin", Method.POST);
            //request2.AddHeader("Content-Type", "application/json");
            //request2.AddJsonBody(user);
            //IRestResponse response2= client.Execute(request2);
            //var content2 = response2.Content;
            //var data2 = JsonConvert.DeserializeObject<Token>(content2);
            Token companytoken = (Token)ApiHelper.Post<Token>("Auth/CompanyLogin", user);

            if (companytoken.token != null)
            {
                //var request3 = new RestRequest("Company/GetLoginUser", Method.GET);
                //request3.AddHeader("Content-Type", "application/json");
                //request3.AddHeader("Authorization", "bearer " + data2.token);
                //IRestResponse response3 = client.Execute(request3);
                ////var content3 = response3.Content;
                //var data3 = JsonConvert.DeserializeObject<LoginCompanyUserModel>(content3);

                var companydata = (LoginCompanyUserModel)ApiHelper.Get<LoginCompanyUserModel>("Company/GetLoginUser", token: companytoken.token);
                HttpContext.Session.SetString("CompanyEmail", companydata.CompanyEmail);
                HttpContext.Session.SetString("RoleId", companydata.RoleId.ToString());

                //return RedirectToAction("CompanyPanel");
            }
            
            return RedirectToAction("CompanyPanel");
        }

    }
   

    public class Token
    {
        public string token { get; set; }
    }

    /*public string MD5Olustur(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i & lt; data.Length; i++)
    {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }*/

   
}