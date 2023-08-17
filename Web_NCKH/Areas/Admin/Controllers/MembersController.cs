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
    public class MembersController : Controller
    {
        // GET: Admin/Members
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(int? page)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            var PageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var items = db.Members.OrderByDescending(x => x.Id).ToPagedList(PageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Add()
        {
            ViewBag.LocationCategory = new SelectList(db.LocationCategories.ToList(), "Id", "Title");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Member model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifiedrDate = DateTime.Now;
                if (string.IsNullOrEmpty(model.Alias))
                    model.Alias = Web_NCKH.Models.Common.Filter.FilterChar(model.Title);
                db.Members.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocationCategory = new SelectList(db.LocationCategories.ToList(), "Id", "Title");
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.LocationCategory = new SelectList(db.LocationCategories.ToList(), "Id", "Title");
            var item = db.Members.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedrDate = DateTime.Now;
                model.Alias = Web_NCKH.Models.Common.Filter.FilterChar(model.Title);
                db.Members.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
        [HttpPost]

        public ActionResult Delete(int id)
        {
            var item = db.Members.Find(id);
            if(item != null)
            {
                db.Members.Remove(item);
                db.SaveChanges();
                return Json(new {success = true });
            }
            return Json(new { success = true });
        }
    }
}