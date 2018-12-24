using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathaBusinessApi.Models;
using MarathaBusinessApi.Entity;

namespace MarathaBusinessApi.Controllers
{
    public class AccountController : Controller
    {
        MarathaBusinessEntities _db = new MarathaBusinessEntities();
        RegistrationApiController _objReg = new RegistrationApiController();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblSkyAdmin model)
        {
             var result = _db.tblSkyAdmins.Where(psd=>psd.UserId==model.UserId && psd.Password==model.Password).FirstOrDefault();

           // var result = _objReg.AdminLogin(model);

            if(result!=null)
            {
                return RedirectToAction("AdminIndex","Dashboard");
            }

            return View();
        }


    }
}