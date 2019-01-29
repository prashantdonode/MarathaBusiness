using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathaBusinessApi.Models;
using MarathaBusinessApi.Entity;
using System.IO;

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

        public ActionResult OccupationList()
        {
            var result = _objReg.GetOccupationList();

            return PartialView(result.Result.Response);
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

        #region Upload Image

        [HttpPost]

        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }

        #endregion



    }
}
