using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using START.Models;

namespace START.Controllers
{
    public class EmergencyTypesController : Controller
    {
        private EventsDb db = new EventsDb();

        // GET: EmergencyTypes
        public ActionResult Index()
        {
            return View(db.Emergency.ToList());
        }

        // GET: EmergencyTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmergencyType emergencyType = db.Emergency.Find(id);
            if (emergencyType == null)
            {
                return HttpNotFound();
            }
            return View(emergencyType);
        }

        // GET: EmergencyTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmergencyTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Emergency")] EmergencyType emergencyType)
        {
            if (ModelState.IsValid)
            {
                db.Emergency.Add(emergencyType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emergencyType);
        }

        // GET: EmergencyTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmergencyType emergencyType = db.Emergency.Find(id);
            if (emergencyType == null)
            {
                return HttpNotFound();
            }
            return View(emergencyType);
        }

        // POST: EmergencyTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Emergency")] EmergencyType emergencyType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emergencyType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emergencyType);
        }

        // GET: EmergencyTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmergencyType emergencyType = db.Emergency.Find(id);
            if (emergencyType == null)
            {
                return HttpNotFound();
            }
            return View(emergencyType);
        }

        // POST: EmergencyTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmergencyType emergencyType = db.Emergency.Find(id);
            db.Emergency.Remove(emergencyType);
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
