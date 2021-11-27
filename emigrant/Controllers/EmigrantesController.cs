using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using emigrant.Data;
using emigrant.Models;

namespace emigrant.Controllers
{
    public class EmigrantesController : Controller
    {
        private emigrantContext db = new emigrantContext();

        // GET: Emigrantes
        public ActionResult Index()
        {
            return View(db.Emigrantes.ToList());
        }

        // GET: Emigrantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emigrante emigrante = db.Emigrantes.Find(id);
            if (emigrante == null)
            {
                return HttpNotFound();
            }
            return View(emigrante);
        }

        // GET: Emigrantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emigrantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,apellidos,tipoIdentificacion,numeroIdentificacion,pais,fechaNacimiento,correoElectronico,numeroTelefonico,direccionActual,ciudad,situacionLaboral")] Emigrante emigrante)
        {
            if (ModelState.IsValid)
            {   
                

                db.Emigrantes.Add(emigrante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            

            return View(emigrante);
        }

        // GET: Emigrantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emigrante emigrante = db.Emigrantes.Find(id);
            if (emigrante == null)
            {
                return HttpNotFound();
            }
            return View(emigrante);
        }

        // POST: Emigrantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,apellidos,tipoIdentificacion,numeroIdentificacion,pais,fechaNacimiento,correoElectronico,numeroTelefonico,direccionActual,ciudad,situacionLaboral")] Emigrante emigrante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emigrante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emigrante);
        }

        // GET: Emigrantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emigrante emigrante = db.Emigrantes.Find(id);
            if (emigrante == null)
            {
                return HttpNotFound();
            }
            return View(emigrante);
        }

        // POST: Emigrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emigrante emigrante = db.Emigrantes.Find(id);
            db.Emigrantes.Remove(emigrante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        //Consulta de Base de datos
        List<DNI> ListDNI() { 
            List<DNI> DNI = new List<DNI>();
            return DNI;
        }


       


    }
}
