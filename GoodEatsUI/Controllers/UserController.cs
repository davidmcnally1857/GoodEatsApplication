using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodEatsUI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
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