﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationLibrary.Models
{
    public class AuthenticatedUser : IAuthenticatedUser
    {
        public string Access_Token { get; set; }
        public string UserName { get; set; }
    }
}
