using DataManager.Library.DataAccess;
using DataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserAccAPI.Controllers
{

    [Authorize]
    [RoutePrefix("api/User")]

    public class UserController : ApiController
    {

        public UserController()
        {

        }

        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }

    //    [HttpGet]

    //    public
    }
}
