using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product : ItemWithId
    {
        public string Title { get; set; }
    }
}