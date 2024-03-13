using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webapplication.Models;

namespace webapplication.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Notes()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
    }
}
