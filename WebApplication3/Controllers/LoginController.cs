using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "gfgfgf";
        }

        [HttpPost]
        [Route("")]
        public string Post([FromBody]User info)
        {
            return StoreDB.UserToken;
        }
    }
}
