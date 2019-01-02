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
                _objBusiness.NameofBusiness = model.NameofBusiness;
                _objBusiness.TypeofBusiness = model.TypeofBusiness;
                _objBusiness.Contact = model.Contact;
                _objBusiness.Address = model.Address;               
                _objBusiness.Email = model.Email;
                _objBusiness.Website = model.Website;
                _objBusiness.AboutBusiness = model.AboutBusiness;
                _objBusiness.Services = model.Services;
                _objBusiness.BestPrice = model.BestPrice;
                _objBusiness.Document = model.Document;
                _objBusiness.Status = model.Status;

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
                var result = _db.tblBusinessManRegistrations.Where(psd => psd.TypeofBusiness == model.TypeofBusiness && psd.Status==model.Status).ToList();

                return new ProjectResult { Message="Success",Status=1,Response=result};

            }catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion

        #region Get All Business Man Information For Customer Search Id wise

        [HttpPost]
        public async Task<ProjectResult> CustomerSearchIdWise(tblBusinessManRegistration model)
        {
            try
            {
                var result = _db.tblBusinessManRegistrations.Where(psd => psd.Bid == model.Bid).ToList();

                return new ProjectResult { Message = "Success", Status = 1, Response = result };

            }
            catch (Exception exp)
            {
                return new ProjectResult { Message = exp.ToString(), Status = 0, Response = null };
            }
        }

        #endregion

        #region Get All Business Man Information

        [HttpGet]
        public async Task<ProjectResult> CustomerSearch(tblBusinessManRegistration model)
        {
            try
            {
                var result = _db.tblBusinessManRegistrations.ToList();

                return new ProjectResult { Message = "Success", Status = 1, Response = result };

            }
            catch (Exception exp)
            {
                return new ProjectResult { Message = exp.ToString(), Status = 0, Response = null };
            }
        }

        #endregion


    }
}
