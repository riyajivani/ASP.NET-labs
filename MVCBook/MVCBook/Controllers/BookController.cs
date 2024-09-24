using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index(int id)
        {
            BookContext bookContext = new BookContext();
            Book book = bookContext.books.Single(b => b.isbn_no == id);
            if (book == null)
            {
                return HttpNotFound(); 
            }
            return View(book);
        }
    }
}