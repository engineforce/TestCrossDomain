using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestCrossDomainB.Models;

namespace TestCrossDomainB.Controllers.WebApi
{
    public class AccountController : ApiController
    {
        [HttpPost, HttpOptions]
        public LoginResponse Login(LoginModel loginModel)
        {
            if (Request.Method == HttpMethod.Options)
                return null;

            if (loginModel.UserFullName == "pli@iress" &&
                loginModel.Password == "678")
            {
                return new LoginResponse()
                {
                    ErrorState = "NoError",
                };
            }

            throw new Exception("Login failed");
        }
    }
}
