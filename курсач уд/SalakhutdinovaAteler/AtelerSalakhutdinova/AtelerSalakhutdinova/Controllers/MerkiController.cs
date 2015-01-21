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
    public class MerkiController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Merki/

        public ActionResult Index()
        {
            return View(db.Мерки.ToList());
        }

        //
        // GET: /Merki/Details/5

        public ActionResult Details(int id = 0)
        {
            Мерки мерки = db.Мерки.Find(id);
            if (мерки == null)
            {
                return HttpNotFound();
            }
            return View(мерки);
        }

        //
        // GET: /Merki/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Merki/Create

        [HttpPost]
        public ActionResult Create(Мерки мерки)
        {
            if (ModelState.IsValid)
            {
                db.Мерки.Add(мерки);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(мерки);
        }

        //
        // GET: /Merki/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Мерки мерки = db.Мерки.Find(id);
            if (мерки == null)
            {
                return HttpNotFound();
            }
            return View(мерки);
        }

        //
        // POST: /Merki/Edit/5

        [HttpPost]
        public ActionResult Edit(Мерки мерки)
        {
            if (ModelState.IsValid)
            {
                db.Entry(мерки).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(мерки);
        }

        //
        // GET: /Merki/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Мерки мерки = db.Мерки.Find(id);
            if (мерки == null)
            {
                return HttpNotFound();
            }
            return View(мерки);
        }

        //
        // POST: /Merki/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Мерки мерки = db.Мерки.Find(id);
            db.Мерки.Remove(мерки);
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