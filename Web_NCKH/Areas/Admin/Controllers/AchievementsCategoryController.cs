using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;
using Web_NCKH.Models.EF;

namespace Web_NCKH.Areas.Admin.Controllers
{
    public class AchievementsCategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/AchievementsCategory
        public ActionResult Index(int? page)
        {
            var pageSize = 5;
            if(page == null)
            {
                page = 1;
            }
            var PageIndex = page.HasValue ? page.Value : 1;
            var items = db.AchievementsCategories.OrderByDescending(x => x.Id).ToPagedList(PageIndex,pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AchievementsCategory model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifiedrDate = DateTime.Now;
                if(string.IsNullOrEmpty(model.Alias))
                    model.Alias = Web_NCKH.Models.Common.Filter.FilterChar(model.Title);
                db.AchievementsCategories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = db.AchievementsCategories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AchievementsCategory model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedrDate = DateTime.Now;
                model.Alias = Web_NCKH.Models.Common.Filter.FilterChar(model.Title);
                db.AchievementsCategories.Attach(model);
                db.Entry(model).Property(x => x.Title).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedrDate).IsModified = true;
                db.Entry(model).Property(x => x.ModifierBy).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.AchievementsCategories.Find(id);
            if(item != null)
            {
                db.AchievementsCategories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}