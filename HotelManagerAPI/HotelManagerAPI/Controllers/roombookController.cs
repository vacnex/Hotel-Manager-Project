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
    public class roombookController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/roombook
        public IQueryable<tbl_roombook> Gettbl_roombook()
        {
            return db.tbl_roombook;
        }

        // GET: api/roombook/5
        [ResponseType(typeof(tbl_roombook))]
        public IHttpActionResult Gettbl_roombook(int id)
        {
            tbl_roombook tbl_roombook = db.tbl_roombook.Find(id);
            if (tbl_roombook == null)
            {
                return NotFound();
            }

            return Ok(tbl_roombook);
        }

        // PUT: api/roombook/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_roombook(int id, tbl_roombook tbl_roombook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_roombook.idRoombook)
            {
                return BadRequest();
            }

            db.Entry(tbl_roombook).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_roombookExists(id))
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

        // POST: api/roombook
        [ResponseType(typeof(tbl_roombook))]
        public IHttpActionResult Posttbl_roombook(tbl_roombook tbl_roombook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_roombook.Add(tbl_roombook);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbl_roombook.idRoombook }, tbl_roombook);
        }

        // DELETE: api/roombook/5
        [ResponseType(typeof(tbl_roombook))]
        public IHttpActionResult Deletetbl_roombook(int id)
        {
            tbl_roombook tbl_roombook = db.tbl_roombook.Find(id);
            if (tbl_roombook == null)
            {
                return NotFound();
            }

            db.tbl_roombook.Remove(tbl_roombook);
            db.SaveChanges();

            return Ok(tbl_roombook);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_roombookExists(int id)
        {
            return db.tbl_roombook.Count(e => e.idRoombook == id) > 0;
        }
    }
}