using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathaBusinessApi.Models;
using MarathaBusinessApi.Entity;

namespace MarathaBusinessApi.Controllers
{
    public class HomeController : Controller
    {

        RegistrationApiController _objReg = new RegistrationApiController();
        MarathaBusinessEntities _db = new MarathaBusinessEntities();

        public ActionResult Index()
        {
            ViewBag.Title = "SkyVision IT Solutions";

            return View();
        }


        #region New Business Man Registration Action and Methods

        public ActionResult BusinessManRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BusinessManRegistration(tblBusinessManRegistration model)
        {
            var result = _objReg.BusinessManRegistration(model);
            ViewBag.message = result.Result.Status;

            ModelState.Clear();

            return View();
        }

        [HttpPost]
        public JsonResult GetOccupation()
        {
            var Occupationlist =_objReg.GetOccupationList();

            return new JsonResult { Data = new { departmentlist = Occupationlist.Result.Response } };
        }

        #endregion


        #region Add Occupation With Its Partial Method

        public ActionResult AddOccupation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOccupation(tblOccupation model)
        {
            var result = _objReg.AddOccupation(model);

            ModelState.Clear();

            return View();
        }

        public ActionResult OccupationAllList()
        {
            var result = _objReg.GetOccupationList();

            return PartialView(result.Result.Response);
        }

        #endregion


        #region Edit Occupations List Of Items

        public ActionResult Edit(int id)
        {
            var result = _db.tblOccupations.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(tblOccupation model)
        {
            tblOccupation _objocc = _db.tblOccupations.Where(psd=>psd.Oid==model.Oid).FirstOrDefault();

            _objocc.Occupation = model.Occupation;

            _db.Entry(_objocc).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            

            return RedirectToAction("AddOccupation", "Home");
        }

        #endregion


        #region Delete Occupations List of Items

        public ActionResult Delete(int id)
        {
            var result = _db.tblOccupations.Find(id);

            _db.Entry(result).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();

            return RedirectToAction("AddOccupation", "Home");
        }

        #endregion


        #region Search Information By Customer Or End User

        public ActionResult CustomerSearch(string Occupation)
        {
            tblBusinessManRegistration model = new tblBusinessManRegistration();
            model.TypeofBusiness = Occupation;
            model.Status = 1;
            var result = _objReg.CustomerSearchOccupation(model);


            return View(result.Result.Response);
        }

        #endregion

    }
}
