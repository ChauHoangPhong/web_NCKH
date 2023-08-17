using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_NCKH.Models;

namespace Web_NCKH.Controllers
{
    public class ProjectsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Projects
        public ActionResult Index()
        {
            var items = db.Projects.ToList();
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.Projects.Find(id);
            return View(item);
        }
    }
}