using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200Team8.Models;

namespace MIS4200Team8.Controllers
{
    public class sendPointsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: sendPoints
        public ActionResult Index()
        {
            return View(db.sendPoints.ToList());
        }

        // GET: sendPoints/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPoints.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            return View(sendPoints);
        }

        // GET: sendPoints/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sendPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,firstName,lastName,coreValue,points")] sendPoints sendPoints)
        {
            if (ModelState.IsValid)
            {
                sendPoints.Guid = Guid.NewGuid();
                db.sendPoints.Add(sendPoints);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sendPoints);
        }

        // GET: sendPoints/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPoints.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            return View(sendPoints);
        }

        // POST: sendPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,firstName,lastName,coreValue,points")] sendPoints sendPoints)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sendPoints).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sendPoints);
        }

        // GET: sendPoints/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPoints.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            return View(sendPoints);
        }

        // POST: sendPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            sendPoints sendPoints = db.sendPoints.Find(id);
            db.sendPoints.Remove(sendPoints);
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
