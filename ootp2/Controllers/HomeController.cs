using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ootp2.Models;

namespace ootp2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }

        [HttpGet]
public ActionResult Buy(int id)
{
    ViewBag.BookId = id;
    return View();
}
[HttpPost]
public string Buy(Order order)
{
    order.Date = DateTime.Now;
    db.Purchases.Add(order);
    db.SaveChanges();
    return "Спасибо," + order.Person + ", за покупку!";
}
    }
}