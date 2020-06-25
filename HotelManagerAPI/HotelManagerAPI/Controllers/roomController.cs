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
    public class roomController : ApiController
    {
        private HotelManagerDBContext db = new HotelManagerDBContext();

        // GET: api/room
        public IQueryable<tbl_room> Gettbl_room()
        {
            return db.tbl_room;
        }

        // GET: api/room/5
        [ResponseType(typeof(tbl_room))]
        public IHttpActionResult Gettbl_room(string id)
        {
            tbl_room tbl_room = db.tbl_room.Find(id);
            if (tbl_room == null)
            {
                return NotFound();
            }

            return Ok(tbl_room);
        }

        // PUT: api/room/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_room(string id, tbl_room tbl_room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_room.idRoom)
            {
                return BadRequest();
            }

            db.Entry(tbl_room).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_roomExists(id))
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

        // POST: api/room
        [ResponseType(typeof(tbl_room))]
        public IHttpActionResult Posttbl_room(tbl_room tbl_room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_room.Add(tbl_room);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_roomExists(tbl_room.idRoom))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_room.idRoom }, tbl_room);
        }

        // DELETE: api/room/5
        [ResponseType(typeof(tbl_room))]
        public IHttpActionResult Deletetbl_room(string id)
        {
            tbl_room tbl_room = db.tbl_room.Find(id);
            if (tbl_room == null)
            {
                return NotFound();
            }

            db.tbl_room.Remove(tbl_room);
            db.SaveChanges();

            return Ok(tbl_room);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_roomExists(string id)
        {
            return db.tbl_room.Count(e => e.idRoom == id) > 0;
        }
    }
}