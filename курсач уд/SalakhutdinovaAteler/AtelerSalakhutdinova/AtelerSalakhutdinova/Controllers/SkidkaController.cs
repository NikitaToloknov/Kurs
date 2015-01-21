using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtelerSalakhutdinova.Models;

namespace AtelerSalakhutdinova.Controllers
{
    public class SkidkaController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Skidka/

        public ActionResult Index()
        {
            return View(db.Скидка.ToList());
        }

        //
        // GET: /Skidka/Details/5

        public ActionResult Details(int id = 0)
        {
            Скидка скидка = db.Скидка.Find(id);
            if (скидка == null)
            {
                return HttpNotFound();
            }
            return View(скидка);
        }

        //
        // GET: /Skidka/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Skidka/Create

        [HttpPost]
        public ActionResult Create(Скидка скидка)
        {
            if (ModelState.IsValid)
            {
                db.Скидка.Add(скидка);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(скидка);
        }

        //
        // GET: /Skidka/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Скидка скидка = db.Скидка.Find(id);
            if (скидка == null)
            {
                return HttpNotFound();
            }
            return View(скидка);
        }

        //
        // POST: /Skidka/Edit/5

        [HttpPost]
        public ActionResult Edit(Скидка скидка)
        {
            if (ModelState.IsValid)
            {
                db.Entry(скидка).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(скидка);
        }

        //
        // GET: /Skidka/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Скидка скидка = db.Скидка.Find(id);
            if (скидка == null)
            {
                return HttpNotFound();
            }
            return View(скидка);
        }

        //
        // POST: /Skidka/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Скидка скидка = db.Скидка.Find(id);
            db.Скидка.Remove(скидка);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}