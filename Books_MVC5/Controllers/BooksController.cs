using Books_MVC5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_MVC5.Models;
using Books_MVC5.ViewModels;

namespace Books_MVC5.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookContext _context;

        public BooksController()
        {
            _context = new BookContext();
        }
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new BookFormViewModel
            {
                Categories = _context.Categories.Where(m => m.IsActive).ToList()
            };

            return View("Create", viewModel);
        }







    }
}