using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TestCrossDomainB.Models;

namespace TestCrossDomainB.Controllers
{
    public class AccountController : Controller
    {
        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Options)]
        public ActionResult Login(LoginModel loginModel)
        {
            if (Request.HttpMethod == HttpMethod.Options.ToString())
                return new EmptyResult();

            if (loginModel.UserFullName == "pli@iress" &&
                loginModel.Password == "678")
            {
                var response = new LoginResponse()
                {
                    ErrorState = "NoError",
                };

                return Json(response);
            }

            throw new Exception("Login failed");
        }
    }
}