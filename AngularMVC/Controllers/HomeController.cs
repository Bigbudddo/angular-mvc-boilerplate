﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMVC.Controllers {

    public class HomeController : BaseController {

        public ActionResult Dashboard() {
            return View();
        }

        public ActionResult Index() {
            ViewBag.state = "dashboard";
            return View();
        }

        public ActionResult Nakama() {
            return View();
        }
    }
}