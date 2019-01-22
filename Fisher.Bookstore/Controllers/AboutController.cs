using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller 
    {
        public IActionResult Index()
        {
            return Content ("About Index");
        }
        public IActionResult History()
        {
            return Content ("About History");
        }
        public IActionResult Location()
        {
            return Content ("About Location");
        }
    }
}
