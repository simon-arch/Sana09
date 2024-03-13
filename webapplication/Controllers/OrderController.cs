using Microsoft.AspNetCore.Mvc;
using webapplication.Models;

namespace webapplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Buy(int id)
        {
            Product product = new Product();
            product.Id = id;
            switch (id)
            {
                case 1: product.Name = "Apples"; break;
                case 2: product.Name = "Bread"; break;
                case 3: product.Name = "Milk"; break;
                case 4: product.Name = "Eggs"; break;
            }
            product.Price = 50;
            return View(product);
        }
    }
}
