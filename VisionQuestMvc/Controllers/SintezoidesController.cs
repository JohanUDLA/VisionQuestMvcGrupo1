using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VisionQuestMvc.Models;

namespace VisionQuestMvc.Controllers
{
    public class SintezoidesController : Controller
    {
        private VisionQuestContext db = new VisionQuestContext();

        // GET: Sintezoides
        public ActionResult Index()
        {
            return View(db.Sintezoides.ToList());
        }

        // GET: Sintezoides/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sintezoide sintezoide = db.Sintezoides.Find(id);
            if (sintezoide == null)
            {
                return HttpNotFound();
            }
            return View(sintezoide);
        }

        // GET: Sintezoides/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sintezoides/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombre,Modelo,NivelIA,FuenteEnergia")] Sintezoide sintezoide)
        {
            if (ModelState.IsValid)
            {
                db.Sintezoides.Add(sintezoide);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sintezoide);
        }

        // GET: Sintezoides/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sintezoide sintezoide = db.Sintezoides.Find(id);
            if (sintezoide == null)
            {
                return HttpNotFound();
            }
            return View(sintezoide);
        }

        // POST: Sintezoides/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombre,Modelo,NivelIA,FuenteEnergia")] Sintezoide sintezoide)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sintezoide).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sintezoide);
        }

        // GET: Sintezoides/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sintezoide sintezoide = db.Sintezoides.Find(id);
            if (sintezoide == null)
            {
                return HttpNotFound();
            }
            return View(sintezoide);
        }

        // POST: Sintezoides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sintezoide sintezoide = db.Sintezoides.Find(id);
            db.Sintezoides.Remove(sintezoide);
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
