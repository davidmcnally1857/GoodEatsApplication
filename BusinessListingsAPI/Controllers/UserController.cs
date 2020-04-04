using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusinessListingsAPI.Controllers
{
    public class UserController : ApiController
    {
        public string Login()
        {
            return "Login Successful";
        }

        public string Register()
        {
            return "Registration Successful";
        }
    }
}
