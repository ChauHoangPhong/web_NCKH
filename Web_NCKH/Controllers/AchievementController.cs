using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class AchievementController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Achievement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AchieveCategory(string alias,int id)
        {
            var items = db.Achievements.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.AchievementsDateID == id).ToList();
            }
            var cate = db.AchievementsDates.Find(id);
            if(cate != null)
            {
                ViewBag.CateName = cate.Date;
            }
            ViewBag.CateId = id;
            return View(items);
        }
        public ActionResult AchiCate()
        {
            var items = db.AchievementsCategories.ToList();
            return PartialView("_AchiCate",items);
        }
    }
}