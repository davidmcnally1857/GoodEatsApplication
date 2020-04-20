using GoodEatsUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplicationLibrary.Api;
using WebApplicationLibrary.Models;

namespace GoodEatsUI.Controllers
{



    public class UserController : Controller
    {

      
        private IAuthenticatedUser _user;
        private ILoginAction _login;

    
        public UserController(IAuthenticatedUser user, ILoginAction login)
        {
           
            _user = user;
            _login = login;
        }

        public string Index()
        {
            return "Login denied";
        }


        public async Task<ActionResult> Login(FormCollection collection)
        {

             string username = collection[0];
             string password = collection[1];

            if (await _login.Login(username, password))
            {

                // return "Login Successful";

                return RedirectToAction("Index", "Home");
            }

            else return RedirectToAction("Index");

        }

                    
       

        public ActionResult LoginConfirmation(AuthenticatedUser result)
        {
            _user.Access_Token = result.Access_Token;
            _user.UserName = result.UserName;

            return RedirectToAction("Index", "Home");



        }
    }
}