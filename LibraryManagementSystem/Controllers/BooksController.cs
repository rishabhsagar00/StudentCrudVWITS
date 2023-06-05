using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private BookDataAccess bookDataAccess = new BookDataAccess();

        public ActionResult Index()
        {
            List<Book> books = bookDataAccess.GetAllBooks();
            return View(books);
        }

        // Implement other controller actions for CRUD operations
    }

}