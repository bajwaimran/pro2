using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevExpress.Xpo;
using MasspackWebApi.Models;
using BestellErfassung.DomainObjects;

namespace MasspackWebApi.Controllers
{
    public class OrdersController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Orders
        public IHttpActionResult Get()
        {
            //HttpResponseMessage();
            //List<MassOrder> list = new List<MassOrder>();
            //var model = unitOfWork.Query<Bestellung>();
            //foreach (var obj in model)
            //{

            //    list.Add(new Art
            //    {
            //        Nr = obj.ArtNrInt,
            //        Artikeltext1 = obj.Artikeltext1,
            //        Artikeltext2 = obj.Artikeltext2,
            //        Artikeltext3 = obj.Artikeltext3,
            //        Bestand = obj.Bestand,
            //        Bezeichnung = obj.Bezeichnung,
            //        Verpackungseinheit = obj.Verpackungseinheit
            //    });
            //}
            //return Ok(list.ToArray());
            return Ok();
        }

        // GET: api/Orders/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orders
        /* { "KundenIds": [1,2,4], "ArtikelIds" : [1001,1002,2001] } */
        public IHttpActionResult Post(MassOrder item)
        {
            return Ok(item);
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
