using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3
{
    public static class StoreDB
    {
        public static List<User> Users { get; private set; }
        public static List<Category> Categories { get; private set; }
        public static List<Product> Products { get; private set; }
        public static List<Order> Orders { get; private set; }
        public static Dictionary<int, List<int>> CategoryToProducts;
        public static string UserToken { get; internal set; }

        static StoreDB()
        {
            UserToken = "hfdj13urfrjgdfh43k";
            Users = new List<User>()
            {
                new User() { Id = 1, Username = "Ben", Phone = "123123"  },
                new User() { Id = 2, Username = "Raz", Phone = "456456"  }
            };
            Categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Furniture" },
                new Category() { Id = 2, Name = "Electronic" }
            };
            Products = new List<Product>()
            {
                new Product() { Id = 1, Title = "Fridge"  },
                new Product() { Id = 2, Title = "Bed"  },
                new Product() { Id = 3, Title = "TV"  },
                new Product() { Id = 4, Title = "Table"  }
            };
            CategoryToProducts = new Dictionary<int, List<int>>()
            {
                [1] = new List<int>() { 2, 4 },
                [2] = new List<int>() { 1, 3 }
            };
            Orders = new List<Order>()
            {
                new Order() { Id = 1, UserId = 1,
                    ProductsToAmount = new Dictionary<int, int>() { [1]  = 1, [3]  = 4 } }, //Ben Ordered 1 Fridge and 4 TVs
                new Order() { Id = 2, UserId = 2,
                    ProductsToAmount = new Dictionary<int, int>() { [4]  = 1 } }, //Raz Ordered 1 Table
                new Order() { Id = 3, UserId = 1,
                    ProductsToAmount = new Dictionary<int, int>() { [2]  = 2 } } //Ben Ordered 2 Ben
            };
        }
    }
}