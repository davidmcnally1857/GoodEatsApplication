using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplicationLibrary.Api;
using WebApplicationLibrary.Models;

namespace GoodEatsUI.Models
{
    public class LoginAction : ILoginAction
    {

        private IAPIHelper _apiHelper;
        private IAuthenticatedUser _user;
     


        public LoginAction(IAuthenticatedUser user, IAPIHelper apiHelper)
        {
            _user = user;
            _apiHelper = apiHelper;
          
        }

        public async Task<bool> Login(string username, string password)
        {

            bool isLoggedIn = false;


            try
            {


              

                _user = await _apiHelper.Authenticate(username, password);

                isLoggedIn = true;



            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }



            return isLoggedIn;


        }

    }
}