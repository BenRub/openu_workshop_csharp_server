using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : BaseController<User>
    {
        public UsersController() : base(StoreDB.Users) { }

        [HttpGet, Route("")]
        public override List<User> Select() { return base.Select(); }

        [HttpGet, Route("{id:int}")]
        public override User Select(int id) { return base.Select(id); }

        [HttpPost, Route("")]
        public override void Create([FromBody]User User) { base.Create(User); }

        [HttpPut, Route("{id:int}")]
        public override void Update(int id, [FromBody]User User) { base.Update(id, User); }

        [HttpDelete, Route("{id:int}")]
        public override void Remove(int id) { base.Remove(id); }
    }
}
