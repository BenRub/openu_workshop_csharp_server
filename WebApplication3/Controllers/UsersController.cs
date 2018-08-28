﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UsersController : BaseController<User>
    {
        public UsersController() : base(StoreDB.Users) { }
    }
}