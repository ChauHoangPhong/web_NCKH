using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_NCKH
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Trangchu",
               url: "trang-chu",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Web_NCKH.Controllers" }
           );
            routes.MapRoute(
              name: "DetailNews",
              url: "{alias}-n{id}",
              defaults: new { controller = "New", action = "Detail", id = UrlParameter.Optional },
              namespaces: new[] { "Web_NCKH.Controllers" }
          );
            routes.MapRoute(
               name: "AchievementsList",
               url: "thanh-tuu",
               defaults: new { controller = "Achievement", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Web_NCKH.Controllers" }
           );
            routes.MapRoute(
               name: "AchievementsDetail",
               url: "chi-tiet-thanh-tuu/{alias}-{id}",
               defaults: new { controller = "Achievement", action = "AchieveCategory", id = UrlParameter.Optional },
               namespaces: new[] { "Web_NCKH.Controllers" }
           );
            routes.MapRoute(
                name: "NewsList",
                url: "tin-tuc",
                defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional },
                namespaces: new[]{"Web_NCKH.Controllers"}
            );
            routes.MapRoute(
                name: "NewsRecruitments",
                url: "tuyen-dung",
                defaults: new { controller = "Recruitment", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web_NCKH.Controllers" }
            );
            routes.MapRoute(
                name: "NewsMember",
                url: "thanh-vien",
                defaults: new { controller = "Members", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web_NCKH.Controllers" }
            );
            routes.MapRoute(
                name: "DetailRecruiment",
                url: "{alias}-i{id}",
                defaults: new { controller = "Recruitment", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "Web_NCKH.Controllers" }
            );
            routes.MapRoute(
                name: "NewsProject",
                url: "du-an",
                defaults: new { controller = "Projects", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web_NCKH.Controllers" }
            );
            routes.MapRoute(
                name: "DetailMembers",
                url: "{alias}-m{id}",
                defaults: new { controller = "Members", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "Web_NCKH.Controllers" }
            );
            routes.MapRoute(
                 name: "DetailProjects",
                 url: "{alias}-{id}",
                 defaults: new { controller = "Projects", action = "Detail", id = UrlParameter.Optional },
                 namespaces: new[] { "Web_NCKH.Controllers" }
             );  
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Web_NCKH.Controllers" }
           );
            
        }
    }
}
