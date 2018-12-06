using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionFilters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetImageTag()
        {
            return View();
        }

        [ChildActionOnly] //限制只能由子要求存取，也就是不允許使用者直接在 URL 上面打網址
        public ActionResult ImageTag(string name)
        {
            string filePath = "/Images/"+name+".jpg";
            string imgTag = "<img src=\""+filePath+"\" />";
            return Content(imgTag);
        }
    }
}