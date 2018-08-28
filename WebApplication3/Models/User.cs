using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User : ItemWithId
    {
        public string Name { get; set; }

        public string Phone { get; set; }
    }
}