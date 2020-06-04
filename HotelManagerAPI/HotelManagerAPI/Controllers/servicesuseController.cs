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
    public class servicesuseController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/servicesuse
        public IQueryable<tbl_servicesuse> Gettbl_servicesuse()
        {
            return db.tbl_servicesuse;
        }

        // GET: api/servicesuse/5
        [ResponseType(typeof(tbl_servicesuse))]
        public IHttpActionResult Gettbl_servicesuse(int id)
        {
            tbl_servicesuse tbl_servicesuse = db.tbl_servicesuse.Find(id);
            if (tbl_servicesuse == null)
            {
                return NotFound();
            }

            return Ok(tbl_servicesuse);
        }

        // PUT: api/servicesuse/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_servicesuse(int id, tbl_servicesuse tbl_servicesuse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_servicesuse.idServiceuse)
            {
                return BadRequest();
            }

            db.Entry(tbl_servicesuse).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_servicesuseExists(id))
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

        // POST: api/servicesuse
        [ResponseType(typeof(tbl_servicesuse))]
        public IHttpActionResult Posttbl_servicesuse(tbl_servicesuse tbl_servicesuse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_servicesuse.Add(tbl_servicesuse);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_servicesuseExists(tbl_servicesuse.idServiceuse))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_servicesuse.idServiceuse }, tbl_servicesuse);
        }

        // DELETE: api/servicesuse/5
        [ResponseType(typeof(tbl_servicesuse))]
        public IHttpActionResult Deletetbl_servicesuse(int id)
        {
            tbl_servicesuse tbl_servicesuse = db.tbl_servicesuse.Find(id);
            if (tbl_servicesuse == null)
            {
                return NotFound();
            }

            db.tbl_servicesuse.Remove(tbl_servicesuse);
            db.SaveChanges();

            return Ok(tbl_servicesuse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_servicesuseExists(int id)
        {
            return db.tbl_servicesuse.Count(e => e.idServiceuse == id) > 0;
        }
    }
}