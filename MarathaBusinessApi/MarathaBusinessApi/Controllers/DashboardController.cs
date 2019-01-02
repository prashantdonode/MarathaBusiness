using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathaBusinessApi.Entity;
using MarathaBusinessApi.Models;

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

        public ActionResult DisplayBusinessManRegistrationsList()
        {
            var result = _db.tblBusinessManRegistrations.ToList();

            return View(result);
        }

        #endregion

        #region Delete And Edit Business Man Registrations

        public ActionResult Edit(int id)
        {
            var result = _db.tblBusinessManRegistrations.Find(id);
            return View(result);
        }


        public ActionResult Edit(tblBusinessManRegistration model)
        {
            tblBusinessManRegistration _objBusiness = new tblBusinessManRegistration();
           


            return Redirect("DisplayAllBusinessMan");
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = _db.tblBusinessManRegistrations.Find(id);

            _db.Entry(result).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();

            return View();
        }

        #endregion

    }
}