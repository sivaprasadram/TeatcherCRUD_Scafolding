﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeatcherCRUD_Scafolding.Controllers
{
    public class HomeController : Controller
    {

       
        public ActionResult Index()
        {
            TutorialsCS _context = new TutorialsCS();

            var listofData = _context.Teatchers.ToList();
            return View(listofData);
        }


    }
}