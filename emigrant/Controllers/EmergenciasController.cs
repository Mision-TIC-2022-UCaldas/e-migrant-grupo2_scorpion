using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using emigrant.Models;

namespace emigrant.Controllers
{
    public class EmergenciasController : Controller
    {
        private emigrantContext db = new emigrantContext();

        // GET: Emergencias
        public ActionResult Index()
        {
            return View(db.Emergencias.ToList());
        }

        // GET: Emergencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergencia emergencia = db.Emergencias.Find(id);
            if (emergencia == null)
            {
                return HttpNotFound();
            }
            return View(emergencia);
        }

        // GET: Emergencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emergencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,descripcion,solicitud")] Emergencia emergencia)
        {
            if (ModelState.IsValid)
            {
                db.Emergencias.Add(emergencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emergencia);
        }

        // GET: Emergencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergencia emergencia = db.Emergencias.Find(id);
            if (emergencia == null)
            {
                return HttpNotFound();
            }
            return View(emergencia);
        }

        // POST: Emergencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,descripcion,solicitud")] Emergencia emergencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emergencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emergencia);
        }

        // GET: Emergencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emergencia emergencia = db.Emergencias.Find(id);
            if (emergencia == null)
            {
                return HttpNotFound();
            }
            return View(emergencia);
        }

        // POST: Emergencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emergencia emergencia = db.Emergencias.Find(id);
            db.Emergencias.Remove(emergencia);
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
    }
}
