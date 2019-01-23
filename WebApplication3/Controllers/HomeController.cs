using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        //BookContext db = new BookContext();

        IBookRepository repository = new BookRepository();

        public HomeController()
        {
        }

        public HomeController(IBookRepository _repository)
        {
            repository = _repository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Title = "Books Data";

            return View(repository.GetAll());
        }
        
    }
}
