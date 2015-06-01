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
using WebApplication1.Models;
using ClassLibrary1;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/colors")]
    public class ColorsController : ApiController
    {
        private ColorContext db = new ColorContext();

        // GET: api/Colors
        public IQueryable<Color> GetColors()
        {
            return db.Colors;
        }

        // POST: api/Colors
        
        [ResponseType(typeof(Color))]
        [Route("AddColor/{colorValue}")]
        public IHttpActionResult GetAddColor(string colorValue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Color color = new Color() { ColorValue = colorValue, QueueDateTime = DateTime.Now };
            db.Colors.Add(color);
            db.SaveChanges();

            return Ok("Color Added");
        }

   
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}