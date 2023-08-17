using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class NewController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: New
        public ActionResult Index()
        {
            var items = db.News.ToList();
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.News.Find(id);
            return View(item);
        }
    }
}