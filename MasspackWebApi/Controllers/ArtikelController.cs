using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BestellErfassung.DomainObjects.Artikel;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using MasspackWebApi.Models;

namespace MasspackWebApi.Controllers
{
    public class ArtikelController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Artikel
        public IHttpActionResult Get()
        {
            List<Art> list = new List<Art>();
            var model = unitOfWork.Query<Artikelstamm>();
            foreach(var obj in model)
            {

                list.Add(new Art
                {
                    Nr = obj.ArtNrInt,
                    Artikeltext1 = obj.Artikeltext1,
                    Artikeltext2 = obj.Artikeltext2,
                    Artikeltext3 = obj.Artikeltext3,
                    Bestand = obj.Bestand,
                    Bezeichnung = obj.Bezeichnung,
                    Verpackungseinheit = obj.Verpackungseinheit
                });
            }
            return Ok(list.ToArray());
        }

        // GET: api/Artikel/5
        public IHttpActionResult Get(int id)
        {
            var obj = unitOfWork.FindObject<Artikelstamm>(CriteriaOperator.Parse("Oid==?", id));
            if (obj != null)
            {
                var item = new Art
                {
                    Nr = obj.ArtNrInt,
                    Artikeltext1 = obj.Artikeltext1,
                    Artikeltext2 = obj.Artikeltext2,
                    Artikeltext3 = obj.Artikeltext3,
                    Bestand = obj.Bestand,
                    Bezeichnung = obj.Bezeichnung,
                    Verpackungseinheit = obj.Verpackungseinheit
                };
                return Ok(item);
            }
            else
                return NotFound();
        }

        // POST: api/Artikel
        public IHttpActionResult Post(Art item)
        {
            var artikelstamm = new Artikelstamm(unitOfWork)
            {
                ArtNrInt = item.Nr,
                ArtNr = item.Nr.ToString(),
                Bestand = item.Bestand,
                Bezeichnung = item.Bezeichnung,
                Artikeltext1 = item.Artikeltext1,
                Artikeltext2 = item.Artikeltext2,
                Artikeltext3 = item.Artikeltext3,
                Stueckzahl = item.Stueckzahl,
                Verpackungseinheit = item.Verpackungseinheit
            };
            unitOfWork.CommitChanges();
            var model = unitOfWork.Query<Artikelstamm>();
            return Json(model.ToArray());
        }

        // PUT: api/Artikel/5
        public IHttpActionResult Put(int id, Art item)
        {
            var obj = unitOfWork.FindObject<Artikelstamm>(CriteriaOperator.Parse("Oid==?", id));
            if (obj != null)
            {
                obj.Artikeltext1 = item.Artikeltext1;
                obj.Artikeltext2 = item.Artikeltext2;
                obj.Artikeltext3 = item.Artikeltext3;
                obj.Bestand = item.Bestand;
                obj.Bezeichnung = item.Bezeichnung;
                obj.Verpackungseinheit = item.Verpackungseinheit;
                obj.Save();
                unitOfWork.CommitChanges();
                return Json(obj);
            }
            else
                return NotFound();
        }

        // DELETE: api/Artikel/5
        public IHttpActionResult Delete(int id)
        {
            var item = unitOfWork.FindObject<Artikelstamm>(CriteriaOperator.Parse("Oid==?", id));
            if (item != null)
            {
                unitOfWork.Delete(item);
                //unitOfWork.CommitChanges();
                return Ok("Deleted");
            }
            else
                return NotFound();
        }
    }
}
