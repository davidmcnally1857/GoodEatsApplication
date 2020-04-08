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

        private IAPIHelper _apiHelper;
        private IAuthenticatedUser _user;
        private LoginAction _login;

    
        public UserController(IAuthenticatedUser user, IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
            _user = user;
            _login = new LoginAction(_user, apiHelper);
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



        // GET: User
        
             
        //public async Task Login(FormCollection collection)
        //{
           

        //    try
        //    {


        //        string username = collection[0];
        //        string password = collection[1];

        //       _user = await _apiHelper.Authenticate(username, password);
            
              

        //    }


        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);

        //    }



        //    LoginConfirmation(_user);


        //}

        public ActionResult LoginConfirmation(AuthenticatedUser result)
        {
            _user.Access_Token = result.Access_Token;
            _user.UserName = result.UserName;

            return RedirectToAction("Index", "Home");



        }
    }
}