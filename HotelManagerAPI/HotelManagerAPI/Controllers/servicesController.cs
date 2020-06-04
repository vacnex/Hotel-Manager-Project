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
    public class servicesController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/services
        public IQueryable<tbl_services> Gettbl_services()
        {
            return db.tbl_services;
        }

        // GET: api/services/5
        [ResponseType(typeof(tbl_services))]
        public IHttpActionResult Gettbl_services(string id)
        {
            tbl_services tbl_services = db.tbl_services.Find(id);
            if (tbl_services == null)
            {
                return NotFound();
            }

            return Ok(tbl_services);
        }

        // PUT: api/services/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_services(string id, tbl_services tbl_services)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_services.idService)
            {
                return BadRequest();
            }

            db.Entry(tbl_services).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_servicesExists(id))
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

        // POST: api/services
        [ResponseType(typeof(tbl_services))]
        public IHttpActionResult Posttbl_services(tbl_services tbl_services)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_services.Add(tbl_services);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_servicesExists(tbl_services.idService))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_services.idService }, tbl_services);
        }

        // DELETE: api/services/5
        [ResponseType(typeof(tbl_services))]
        public IHttpActionResult Deletetbl_services(string id)
        {
            tbl_services tbl_services = db.tbl_services.Find(id);
            if (tbl_services == null)
            {
                return NotFound();
            }

            db.tbl_services.Remove(tbl_services);
            db.SaveChanges();

            return Ok(tbl_services);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_servicesExists(string id)
        {
            return db.tbl_services.Count(e => e.idService == id) > 0;
        }
    }
}