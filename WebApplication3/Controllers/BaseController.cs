using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public abstract class BaseController<T> : ApiController where T : ItemWithId
    {
        private List<T> items;
        public BaseController(List<T> items)
        {
            this.items = items;
        }

        public List<T> Get()
        {
            return items;
        }

        public T Get(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "this item does not exist"));
            return item;
        }

        public void Post(T item)
        {
            var id = items.Max(i => i.Id) + 1;
            item.Id = id;
            items.Add(item);
        }
    }
}
