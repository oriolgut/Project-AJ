using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AJ.DAL;
using AJ.Models;
using AJ.ViewModels;

namespace AJ.Controllers
{
    public class AJController : Controller
    {
        private AJContext db = new AJContext();

        // GET: AJ
        public ActionResult Index()
        {
            return View(db.AJs.ToList());
        }

        //// GET: AJ/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AJModel aJModel = db.AJs.Find(id);
        //    if (aJModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aJModel);
        //}

        // GET: AJ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AJ/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,KW,Montag,Dienstag,Mittwoch,Donnerstag,Freitag,Wochenrückblick,Lupe_der_Woche,Reflexion")] AJViewModel aj)
        {
            if (ModelState.IsValid)
            {
                //TODO: database add 
                return RedirectToAction("Index");
            }

            return View(aj);
        }

        //// GET: AJ/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AJModel aJModel = db.AJs.Find(id);
        //    if (aJModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aJModel);
        //}

        //// POST: AJ/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,KW,Montag,Dienstag,Mittwoch,Donnerstag,Freitag,Wochenrückblick,Lupe_der_Woche,Reflexion")] AJModel aJModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(aJModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(aJModel);
        //}

        //// GET: AJ/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AJModel aJModel = db.AJs.Find(id);
        //    if (aJModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aJModel);
        //}

        //// POST: AJ/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    AJModel aJModel = db.AJs.Find(id);
        //    db.AJs.Remove(aJModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
