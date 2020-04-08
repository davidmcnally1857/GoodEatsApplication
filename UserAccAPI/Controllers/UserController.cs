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

    //    [HttpGet]

    //    public
    }
}
