using Example_FormLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_FormLayout.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var model = new Category() { ID = 1, Name = "Fruits", Products = new List<Product>() };
            Session["CategoryData"] = model;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Category cat) {
            return View(cat);
        }
        public ActionResult CategoryFormLayoutPartial(string command)
        {
            Category p = Session["CategoryData"] as Category;
            string[] results = command.Split(';');            
            string action = results[0];
            int index = Convert.ToInt32(results[1]);
            if (action == "add")
            {
                p.Products.Add(new Product() { ProductName = String.Empty });
            }
            else
            {
                p.Products.RemoveAt(index);
            }
            return PartialView(p);
        }
    }
}