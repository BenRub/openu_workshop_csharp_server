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

        public virtual List<T> Select()
        {
            return items;
        }

        public virtual T Select(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "this item does not exist"));
            return item;
        }

        public virtual void Create(T item)
        {
            var id = items.Max(i => i.Id) + 1;
            item.Id = id;
            items.Add(item);
        }

        public virtual void Update(int id, [FromBody]T newItem)
        {
            var item = Select(id);
            newItem.Id = id;
            var index = items.IndexOf(item);
            items[index] = newItem;
        }

        public virtual void Remove(int id)
        {
            var item = Select(id);
            items.Remove(item);
        }
    }
}
