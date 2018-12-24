using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarathaBusinessApi.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult AdminIndex()
        {
            return View();
        }
    }
}