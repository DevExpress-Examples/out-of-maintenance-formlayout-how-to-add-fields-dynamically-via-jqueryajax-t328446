using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_FormLayout.Models
{
    public class Category {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product {
        public string ProductName { get; set; }
    }
}