using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Model.Frameworks;

namespace HotelManagerAPI.Controllers
{
    public class accountController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/account
        public IQueryable<tbl_account> Gettbl_account()
        {
            return db.tbl_account;
        }

        // GET: api/account/5
        [ResponseType(typeof(tbl_account))]
        public IHttpActionResult Gettbl_account(string id)
        {
            tbl_account tbl_account = db.tbl_account.Find(id);
            if (tbl_account == null)
            {
                return NotFound();
            }

            return Ok(tbl_account);
        }

        // PUT: api/account/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_account(string id, tbl_account tbl_account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_account.Username)
            {
                return BadRequest();
            }

            db.Entry(tbl_account).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_accountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/account
        [ResponseType(typeof(tbl_account))]
        public IHttpActionResult Posttbl_account(tbl_account tbl_account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_account.Add(tbl_account);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_accountExists(tbl_account.Username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_account.Username }, tbl_account);
        }

        // DELETE: api/account/5
        [ResponseType(typeof(tbl_account))]
        public IHttpActionResult Deletetbl_account(string id)
        {
            tbl_account tbl_account = db.tbl_account.Find(id);
            if (tbl_account == null)
            {
                return NotFound();
            }

            db.tbl_account.Remove(tbl_account);
            db.SaveChanges();

            return Ok(tbl_account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_accountExists(string id)
        {
            return db.tbl_account.Count(e => e.Username == id) > 0;
        }
    }
}