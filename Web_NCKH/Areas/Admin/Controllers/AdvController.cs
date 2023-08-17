﻿using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;
using Web_NCKH.Models.EF;

namespace Web_NCKH.Areas.Admin.Controllers
{
    public class AdvController : Controller
    {
        // GET: Admin/Adv
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(string Searchtext, int? page)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Adv> items = db.Advs.OrderByDescending(x => x.Id);
            if (!string.IsNullOrEmpty(Searchtext))
            {
                items = items.Where(x => x.Title.Contains(Searchtext));
            }
            var PageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(PageIndex, pageSize);
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
        public ActionResult Add(Adv model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifiedrDate = DateTime.Now;
                db.Advs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = db.Advs.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Adv model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedrDate = DateTime.Now;
                db.Advs.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model) ;
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Advs.Find(id);
            if (item != null)
            {
                db.Advs.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = true });
        }
        [HttpPost]
        public ActionResult DeleteAll(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = db.Advs.Find(Convert.ToInt32(item));
                        db.Advs.Remove(obj);
                        db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}