using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathaBusinessApi.Entity;

namespace MarathaBusinessApi.Controllers
{
    public class DashboardController : Controller
    {
        MarathaBusinessEntities _db = new MarathaBusinessEntities();

        public ActionResult AdminIndex()
        {
            return View();
        }

        #region Diplay All Business Man Registration List

        public ActionResult DisplayAllBusinessMan()
        {
            var result = _db.tblBusinessManRegistrations.ToList();

            return View(result);
        }

        #endregion

        #region Delete Business Man Registrations

        public ActionResult DeleteBusinessMan()
        {
            return View();
        }

        #endregion

    }
}