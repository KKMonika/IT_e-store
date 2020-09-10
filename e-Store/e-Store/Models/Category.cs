using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Store.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Descripton { get; set; }

        public List<Product> Products { get; set; }
    }
}