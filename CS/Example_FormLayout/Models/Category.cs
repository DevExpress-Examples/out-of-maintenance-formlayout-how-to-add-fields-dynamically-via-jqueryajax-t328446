﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_FormLayout.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> Products { get; set; }
    }
}