using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : BaseController<Order>
    {
        public OrdersController() : base(StoreDB.Orders) { }

        [HttpGet, Route("")]
        public override List<Order> Select() { return base.Select(); }

        [HttpGet, Route("{id:int}")]
        public override Order Select(int id) { return base.Select(id); }

        [HttpPost, Route("")]
        public override void Create([FromBody]Order Order) { base.Create(Order); }

        [HttpPut, Route("{id:int}")]
        public override void Update(int id, [FromBody]Order Order) { base.Update(id, Order); }

        [HttpDelete, Route("{id:int}")]
        public override void Remove(int id) { base.Remove(id); }
    }
}
