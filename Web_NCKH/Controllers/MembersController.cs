using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class MembersController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Members
        public ActionResult Index()
        {
            var items = db.Members.ToList();
            return View(items);
        }
        public ActionResult MembersLocation()
        {
            var items = db.LocationCategories.ToList();
            return PartialView("_MembersLocation",items);
        }
        public ActionResult MembersList()
        {
            var items = db.Members.ToList();
            return PartialView(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.Members.Find(id);
            return View(item);
        }
    }
}