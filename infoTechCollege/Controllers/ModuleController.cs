﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace infoTechCollege.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Modules
        public ActionResult ComputerScience()
        {
            return View();
        }

        public ActionResult SoftwareEngineering()
        {
            return View();
        }

        public ActionResult CyberSecurity()
        {
            return View();
        }

        public ActionResult RegisterComputerScience()
        {
            return View();
        }
    }
}