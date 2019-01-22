using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller 
    {
        public IActionResult Index()
        {
            return Content ("Books Index");
        }
        public IActionResult New()
        {
            return Content ("New Books");
        }
        public IActionResult Best()
        {
            return Content ("Best Books");
        }
    }
}