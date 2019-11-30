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
using SolicitudCompra.Models;

namespace SolicitudCompra.Controllers
{
    public class Solicitud_compraController : ApiController
    {
        private Solicitudcompra db = new Solicitudcompra();

        // GET: api/Solicitud_compra
        public IQueryable<Solicitud_compra> GetSolicitud_compra()
        {
            return db.Solicitud_compra;
        }

        // GET: api/Solicitud_compra/5
        [ResponseType(typeof(Solicitud_compra))]
        public IHttpActionResult GetSolicitud_compra(int id)
        {
            Solicitud_compra solicitud_compra = db.Solicitud_compra.Find(id);
            if (solicitud_compra == null)
            {
                return NotFound();
            }

            return Ok(solicitud_compra);
        }

        // PUT: api/Solicitud_compra/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSolicitud_compra(int id, Solicitud_compra solicitud_compra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != solicitud_compra.IdSolicitudCompra)
            {
                return BadRequest();
            }

            db.Entry(solicitud_compra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Solicitud_compraExists(id))
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

        // POST: api/Solicitud_compra
        [ResponseType(typeof(Solicitud_compra))]
        public IHttpActionResult PostSolicitud_compra(Solicitud_compra solicitud_compra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Solicitud_compra.Add(solicitud_compra);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = solicitud_compra.IdSolicitudCompra }, solicitud_compra);
        }

        // DELETE: api/Solicitud_compra/5
        [ResponseType(typeof(Solicitud_compra))]
        public IHttpActionResult DeleteSolicitud_compra(int id)
        {
            Solicitud_compra solicitud_compra = db.Solicitud_compra.Find(id);
            if (solicitud_compra == null)
            {
                return NotFound();
            }

            db.Solicitud_compra.Remove(solicitud_compra);
            db.SaveChanges();

            return Ok(solicitud_compra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Solicitud_compraExists(int id)
        {
            return db.Solicitud_compra.Count(e => e.IdSolicitudCompra == id) > 0;
        }
    }
}