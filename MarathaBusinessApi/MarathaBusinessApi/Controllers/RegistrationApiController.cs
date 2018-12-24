using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using MarathaBusinessApi.Entity;
using MarathaBusinessApi.Models;

namespace MarathaBusinessApi.Controllers
{
    public class RegistrationApiController : ApiController
    {
        MarathaBusinessEntities _db = new MarathaBusinessEntities();


        #region Add New Business Mans Registrations

        [HttpPost]
        public async Task<ProjectResult> BusinessManRegistration(tblBusinessManRegistration model)
        {
            try
            {
                tblBusinessManRegistration _objBusiness = new tblBusinessManRegistration();

                _objBusiness.Name = model.Name;
                _objBusiness.MobileNo = model.MobileNo;
                _objBusiness.Address = model.Address;
                _objBusiness.City = model.City;
                _objBusiness.Email = model.Email;
                _objBusiness.PhoneNo = model.PhoneNo;
                _objBusiness.Occupation = model.Occupation;
                _objBusiness.StoreName = model.StoreName;
                _objBusiness.Document = model.Document;
                _objBusiness.Status = 1;

                _db.tblBusinessManRegistrations.Add(_objBusiness);
                _db.SaveChanges();


                return new ProjectResult { Message = "Success", Status = 1, Response = "Success" };

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion

        #region Add New Occupation In Database

        [HttpPost]
        public async Task<ProjectResult> AddOccupation(tblOccupation model)
        {
            try
            {
                tblOccupation _objOcucc = new tblOccupation();
                _objOcucc.Occupation = model.Occupation;

                _db.tblOccupations.Add(_objOcucc);
                _db.SaveChanges();

                return new ProjectResult { Message="Success",Status=1,Response="Success"};

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion

        #region Get All Occupation List

        [HttpGet]
        public async Task<ProjectResult> GetOccupationList()
        {
            try
            {
                var result = _db.tblOccupations.ToList();

                return new ProjectResult { Message="Success",Status=1,Response=result};

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion

        #region Admin Login Methods

        [HttpPost]
        public async Task<ProjectResult>AdminLogin(tblSkyAdmin model)
        {
            try
            {
                var result = _db.tblSkyAdmins.Where(psd=>psd.UserId==model.UserId && psd.Password==model.Password).ToList();

                return new ProjectResult { Message="Success",Status=1,Response=result};

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }

        }


        #endregion

        #region Get All Business Man Information For Customer Search

        [HttpPost]
        public async Task<ProjectResult>CustomerSearchOccupation(tblBusinessManRegistration model)
        {
            try
            {
                var result = _db.tblBusinessManRegistrations.Where(psd => psd.Occupation == model.Occupation && psd.Status==model.Status).ToList();

                return new ProjectResult { Message="Success",Status=1,Response=result};

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion
    }
}
