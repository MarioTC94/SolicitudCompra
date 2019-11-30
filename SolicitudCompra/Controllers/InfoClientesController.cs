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
    public class InfoClientesController : ApiController
    {
        private Solicitudcompra db = new Solicitudcompra();

        // GET: api/InfoClientes
        public IQueryable<InfoCliente> GetInfoCliente()
        {
            return db.InfoCliente;
        }

        // GET: api/InfoClientes/5
        [ResponseType(typeof(InfoCliente))]
        public IHttpActionResult GetInfoCliente(int id)
        {
            InfoCliente infoCliente = db.InfoCliente.Find(id);
            if (infoCliente == null)
            {
                return NotFound();
            }

            return Ok(infoCliente);
        }

        // PUT: api/InfoClientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInfoCliente(int id, InfoCliente infoCliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != infoCliente.Idcliente)
            {
                return BadRequest();
            }

            db.Entry(infoCliente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoClienteExists(id))
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

        // POST: api/InfoClientes
        [ResponseType(typeof(InfoCliente))]
        public IHttpActionResult PostInfoCliente(InfoCliente infoCliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InfoCliente.Add(infoCliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = infoCliente.Idcliente }, infoCliente);
        }

        // DELETE: api/InfoClientes/5
        [ResponseType(typeof(InfoCliente))]
        public IHttpActionResult DeleteInfoCliente(int id)
        {
            InfoCliente infoCliente = db.InfoCliente.Find(id);
            if (infoCliente == null)
            {
                return NotFound();
            }

            db.InfoCliente.Remove(infoCliente);
            db.SaveChanges();

            return Ok(infoCliente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InfoClienteExists(int id)
        {
            return db.InfoCliente.Count(e => e.Idcliente == id) > 0;
        }
    }
}