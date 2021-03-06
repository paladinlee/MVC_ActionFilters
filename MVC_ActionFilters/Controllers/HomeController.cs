﻿using MVC_ActionFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionFilters.Controllers
{
    public class HomeController : Controller
    {
        [MVC5Authv1]
        public ActionResult Index()
        {
            return View();
        }

        [HelloWorld("Jeff", 5, OrderDrink=Drinks.CAFE)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [MVC5Authv2]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}