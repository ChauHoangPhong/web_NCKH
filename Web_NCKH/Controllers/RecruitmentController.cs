using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class RecruitmentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Recruitment
        public ActionResult Index()
        {
            var items = db.Recruitments.ToList();
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.Recruitments.Find(id);
            return View(item);
        }
    }
}