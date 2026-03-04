using bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bank.Controllers
{
    [RoutePrefix("api")]
    public class BMSController : ApiController
    {
        [HttpGet]
        [Route("getUser/{id}")]

        public IHttpActionResult GetUser(int id)
        {
            try
            {
                var dbHelper = new DbHelper.DbBMS();
                var userData = dbHelper.GetUser(id);
                if (userData.Rows.Count == 0)
                {
                    return NotFound();
                }
                return Ok(userData);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPost]
        [Route("register")]
        public IHttpActionResult RegisterUser(RegisterModel model)
        {
            try
            {
                var dbHelper = new DbHelper.DbBMS();
                var result = dbHelper.RegisterUser(model);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("createAccount")]
        public IHttpActionResult CreateAccount(AccountModel model)
        {
            try
            {
                var dbHelper = new DbHelper.DbBMS();
                var result = dbHelper.CreateAccount(model);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPost]
        [Route("transfer")]
        public IHttpActionResult TransferMoney(TransferModel model)
        {
            try
            {
                var dbHelper = new DbHelper.DbBMS();
                var result = dbHelper.TransferMoney(model);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPost]
        [Route("addMoney")]
        public IHttpActionResult AddMoney(AddMoneyModel model)
        {
            try
            {
                var dbHelper = new DbHelper.DbBMS();
                var result = dbHelper.AddMoney(model);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
