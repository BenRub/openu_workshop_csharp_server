using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : BaseController<Product>
    {
        public ProductsController() : base(StoreDB.Products) { }

        //[HttpGet, Route("")]
        //public override List<Product> Select() { return base.Select(); }

        [HttpGet, Route("{id:int}")]
        public override Product Select(int id) { return base.Select(id); }

        //[HttpPost, Route("")]
        //public override void Create([FromBody]Product Product) { base.Create(Product); }

        [HttpPut, Route("{id:int}")]
        public override void Update(int id, [FromBody]Product Product) { base.Update(id, Product); }

        [HttpDelete, Route("{id:int}")]
        public override void Remove(int id) { base.Remove(id); }
    }
}
