using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using MvcGridTransaction.Models;


namespace MvcGridTransaction.Controllers
{
    public class HomeController : MyController
    {
        public ActionResult Index()
        { 
            ViewBag.IsCurrentMenu = "DASHBOARD";
            return View();
        } 
    }
}
