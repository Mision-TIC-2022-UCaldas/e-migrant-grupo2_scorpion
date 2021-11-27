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
    public class NovedadeController : Controller
    {
        private emigrantContext db = new emigrantContext();

        // GET: Novedade
        public ActionResult Index()
        {
            return View(db.Novedades.ToList());
        }

        // GET: Novedade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedades novedades = db.Novedades.Find(id);
            if (novedades == null)
            {
                return HttpNotFound();
            }
            return View(novedades);
        }

        // GET: Novedade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novedade/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FechaNovedad,DiasActiva,Descripcion")] Novedades novedades)
        {
            if (ModelState.IsValid)
            {
                db.Novedades.Add(novedades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(novedades);
        }

        // GET: Novedade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedades novedades = db.Novedades.Find(id);
            if (novedades == null)
            {
                return HttpNotFound();
            }
            return View(novedades);
        }

        // POST: Novedade/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FechaNovedad,DiasActiva,Descripcion")] Novedades novedades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novedades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(novedades);
        }

        // GET: Novedade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedades novedades = db.Novedades.Find(id);
            if (novedades == null)
            {
                return HttpNotFound();
            }
            return View(novedades);
        }

        // POST: Novedade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novedades novedades = db.Novedades.Find(id);
            db.Novedades.Remove(novedades);
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
