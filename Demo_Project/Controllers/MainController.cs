﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Project.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Login()
        {
            return View();
        }
    }
}