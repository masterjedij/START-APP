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
    public class FirstResponderTypesController : Controller
    {
        private EventsDb db = new EventsDb();

        // GET: FirstResponderTypes
        public ActionResult Index()
        {
            return View(db.FirstResponder.ToList());
        }

        // GET: FirstResponderTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstResponderType firstResponderType = db.FirstResponder.Find(id);
            if (firstResponderType == null)
            {
                return HttpNotFound();
            }
            return View(firstResponderType);
        }

        // GET: FirstResponderTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirstResponderTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstResponder")] FirstResponderType firstResponderType)
        {
            if (ModelState.IsValid)
            {
                db.FirstResponder.Add(firstResponderType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(firstResponderType);
        }

        // GET: FirstResponderTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstResponderType firstResponderType = db.FirstResponder.Find(id);
            if (firstResponderType == null)
            {
                return HttpNotFound();
            }
            return View(firstResponderType);
        }

        // POST: FirstResponderTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstResponder")] FirstResponderType firstResponderType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firstResponderType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firstResponderType);
        }

        // GET: FirstResponderTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirstResponderType firstResponderType = db.FirstResponder.Find(id);
            if (firstResponderType == null)
            {
                return HttpNotFound();
            }
            return View(firstResponderType);
        }

        // POST: FirstResponderTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FirstResponderType firstResponderType = db.FirstResponder.Find(id);
            db.FirstResponder.Remove(firstResponderType);
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
