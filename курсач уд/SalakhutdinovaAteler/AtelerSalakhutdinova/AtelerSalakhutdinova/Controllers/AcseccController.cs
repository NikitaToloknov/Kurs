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
    public class AcseccController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Acsecc/

        public ActionResult Index()
        {
            return View(db.Аксессуары.ToList());
        }

        //
        // GET: /Acsecc/Details/5

        public ActionResult Details(int id = 0)
        {
            Аксессуары аксессуары = db.Аксессуары.Find(id);
            if (аксессуары == null)
            {
                return HttpNotFound();
            }
            return View(аксессуары);
        }

        //
        // GET: /Acsecc/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Acsecc/Create

        [HttpPost]
        public ActionResult Create(Аксессуары аксессуары)
        {
            if (ModelState.IsValid)
            {
                db.Аксессуары.Add(аксессуары);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(аксессуары);
        }

        //
        // GET: /Acsecc/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Аксессуары аксессуары = db.Аксессуары.Find(id);
            if (аксессуары == null)
            {
                return HttpNotFound();
            }
            return View(аксессуары);
        }

        //
        // POST: /Acsecc/Edit/5

        [HttpPost]
        public ActionResult Edit(Аксессуары аксессуары)
        {
            if (ModelState.IsValid)
            {
                db.Entry(аксессуары).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(аксессуары);
        }

        //
        // GET: /Acsecc/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Аксессуары аксессуары = db.Аксессуары.Find(id);
            if (аксессуары == null)
            {
                return HttpNotFound();
            }
            return View(аксессуары);
        }

        //
        // POST: /Acsecc/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Аксессуары аксессуары = db.Аксессуары.Find(id);
            db.Аксессуары.Remove(аксессуары);
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