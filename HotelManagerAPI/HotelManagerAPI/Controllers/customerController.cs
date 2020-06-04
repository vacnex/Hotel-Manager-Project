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
    public class customerController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/customer
        public IQueryable<tbl_customer> Gettbl_customer()
        {
            return db.tbl_customer;
        }

        // GET: api/customer/5
        [ResponseType(typeof(tbl_customer))]
        public IHttpActionResult Gettbl_customer(string id)
        {
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            if (tbl_customer == null)
            {
                return NotFound();
            }

            return Ok(tbl_customer);
        }

        // PUT: api/customer/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_customer(string id, tbl_customer tbl_customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_customer.idCard)
            {
                return BadRequest();
            }

            db.Entry(tbl_customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_customerExists(id))
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

        // POST: api/customer
        [ResponseType(typeof(tbl_customer))]
        public IHttpActionResult Posttbl_customer(tbl_customer tbl_customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_customer.Add(tbl_customer);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_customerExists(tbl_customer.idCard))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_customer.idCard }, tbl_customer);
        }

        // DELETE: api/customer/5
        [ResponseType(typeof(tbl_customer))]
        public IHttpActionResult Deletetbl_customer(string id)
        {
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            if (tbl_customer == null)
            {
                return NotFound();
            }

            db.tbl_customer.Remove(tbl_customer);
            db.SaveChanges();

            return Ok(tbl_customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_customerExists(string id)
        {
            return db.tbl_customer.Count(e => e.idCard == id) > 0;
        }
    }
}