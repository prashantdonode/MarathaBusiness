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

        public ActionResult DisplayAllBusinessMan()
        {
            var result = _db.tblBusinessManRegistrations.ToList();

            return View(result);
        }

        #endregion

        #region Edit And Delete Business Man Registrations

       public ActionResult Edit(int id)
        {
            var result = _db.tblBusinessManRegistrations.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(tblBusinessManRegistration model)
        {
            tblBusinessManRegistration _objBusiness = (from psd in _db.tblBusinessManRegistrations where( psd.Bid==model.Bid) select psd).FirstOrDefault();

            _objBusiness.Name = model.Name;
            _objBusiness.MobileNo = model.MobileNo;
            _objBusiness.Occupation = model.Occupation;
            _objBusiness.PhoneNo = model.PhoneNo;
            _objBusiness.Status = model.Status;
            _objBusiness.StoreName = model.StoreName;
            _objBusiness.Email = model.Email;
            _objBusiness.Document = model.Document;
            _objBusiness.City = model.City;
            _objBusiness.Address = model.Address;

            _db.Entry(_objBusiness).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();


            return RedirectToAction("DisplayAllBusinessMan", "Dashboard");
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = _db.tblBusinessManRegistrations.Find(id);
            _db.Entry(result).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();

            return RedirectToAction("DisplayAllBusinessMan", "Dashboard");
        }

        #endregion

    }
}