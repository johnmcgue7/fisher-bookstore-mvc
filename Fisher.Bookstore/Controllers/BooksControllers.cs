using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller 
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("This is the Books controller's Index action");
        }
        [Route("new")]
        public IActionResult New()
        {
            return Content("This is the Books contoller's New action");

        }
        [Route("best-sellers")]
        public IActionResult Best()
        {
            return Content("This is the Books controller's Best action with a route of 'books/best-sellers");
        }
        
    }
   
    
}