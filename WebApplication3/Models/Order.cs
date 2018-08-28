using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Order : ItemWithId
    {
        public int UserId { get; set; }
        public Dictionary<int, int> ProductsToAmount { get; set; }
        public bool Delivered { get; set; }
    }
}