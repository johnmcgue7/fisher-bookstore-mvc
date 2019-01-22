using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller 
    {
        public IActionResult Index()
        {
            return Content ("Authors Index");
        }
        public IActionResult Featured()
        {
            return Content ("Featured Authors");
        }
    }
}