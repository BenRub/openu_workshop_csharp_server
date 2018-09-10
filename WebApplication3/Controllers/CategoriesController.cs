using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoriesController : BaseController<Category>
    {
        public CategoriesController() : base(StoreDB.Categories) { }

        [HttpGet, Route("")]
        public override List<Category> Select() { return base.Select(); }

        [HttpGet, Route("{id:int}")]
        public override Category Select(int id) { return base.Select(id); }

        [HttpPost, Route("")]
        public override void Create([FromBody]Category category) { base.Create(category); }

        [HttpPut, Route("{id:int}")]
        public override void Update(int id, [FromBody]Category category) { base.Update(id, category); }

        [HttpDelete, Route("{id:int}")]
        public override void Remove(int id) { base.Remove(id); }

        [Route("{categoryId:int}/products")]
        [HttpGet]
        public List<Product> ProductsByCategory(int categoryId)
        {
            List<int> productsIds;
            bool categoryHasProducts = StoreDB.CategoryToProducts.TryGetValue(categoryId, out productsIds);
            if (!categoryHasProducts)
                return new List<Product>();
            return productsIds.Select(pid => StoreDB.Products.FirstOrDefault(p => p.Id == pid)).ToList();
        }

        [Route("{categoryId:int}/products")]
        [HttpPost]
        public void CreateProduct(int categoryId, [FromBody]Product product)
        {
            new ProductsController().Create(product);
            if (!StoreDB.CategoryToProducts.ContainsKey(categoryId))
                StoreDB.CategoryToProducts[categoryId] = new List<int>();
            StoreDB.CategoryToProducts[categoryId].Add(product.Id);
        }
    }
}
