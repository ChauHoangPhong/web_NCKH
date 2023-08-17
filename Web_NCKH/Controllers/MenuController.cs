using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuTop()
        {
            var items = db.Categories.OrderBy(x => x.Position).ToList();
            return PartialView("_MenuTop", items);
        }
        public ActionResult MenuDown()
        {
            var items = db.Categories.OrderBy(x => x.Position).ToList();
            return PartialView("_MenuDown", items);
        }
        public ActionResult MenuTopic()
        {
            var items = db.News.OrderBy(x => x.CreateDate).ToList();
            return PartialView("_MenuTopic",items);
        }
        public ActionResult MenuNewRecrui()
        {
            var items = db.Recruitments.OrderBy(x => x.CreateDate).ToList();
            return PartialView("_MenuNewRecrui", items);
        }
        public ActionResult MenuAdv()
        {
            var items = db.Advs.OrderBy(x => x.Type).ToList();
            return PartialView("_MenuAdv", items);
        }
        public ActionResult MenuAchieveDate()
        {
            var items = db.AchievementsDates.ToList();
            return PartialView("_MenuAchieveDate", items);
        }
        public ActionResult MenuLeft(int? id)
        {
            if(id != null)
            {
                ViewBag.CateId = id;
            }
            var items = db.AchievementsDates.ToList();
            return PartialView("_MenuLeft", items);
        }
    }
}