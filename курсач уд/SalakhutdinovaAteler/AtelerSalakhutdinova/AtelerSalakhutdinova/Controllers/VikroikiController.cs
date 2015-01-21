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
    public class VikroikiController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Vikroiki/

        public ActionResult Index()
        {
            var выкройки = db.Выкройки.Include(в => в.Аксессуары).Include(в => в.Мерки).Include(в => в.СкладТканей);
            return View(выкройки.ToList());
        }

        //
        // GET: /Vikroiki/Details/5

        public ActionResult Details(int id = 0)
        {
            Выкройки выкройки = db.Выкройки.Find(id);
            if (выкройки == null)
            {
                return HttpNotFound();
            }
            return View(выкройки);
        }

        //
        // GET: /Vikroiki/Create

        public ActionResult Create()
        {
            ViewBag.ID_аксессуара = new SelectList(db.Аксессуары, "ID_аксессуара", "Наименование_аксессуара");
            ViewBag.ID_мерки = new SelectList(db.Мерки, "ID_мерки", "Примечания");
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани");
            return View();
        }

        //
        // POST: /Vikroiki/Create

        [HttpPost]
        public ActionResult Create(Выкройки выкройки)
        {
            if (ModelState.IsValid)
            {
                db.Выкройки.Add(выкройки);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_аксессуара = new SelectList(db.Аксессуары, "ID_аксессуара", "Наименование_аксессуара", выкройки.ID_аксессуара);
            ViewBag.ID_мерки = new SelectList(db.Мерки, "ID_мерки", "Примечания", выкройки.ID_мерки);
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", выкройки.ID_ткани);
            return View(выкройки);
        }

        //
        // GET: /Vikroiki/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Выкройки выкройки = db.Выкройки.Find(id);
            if (выкройки == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_аксессуара = new SelectList(db.Аксессуары, "ID_аксессуара", "Наименование_аксессуара", выкройки.ID_аксессуара);
            ViewBag.ID_мерки = new SelectList(db.Мерки, "ID_мерки", "Примечания", выкройки.ID_мерки);
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", выкройки.ID_ткани);
            return View(выкройки);
        }

        //
        // POST: /Vikroiki/Edit/5

        [HttpPost]
        public ActionResult Edit(Выкройки выкройки)
        {
            if (ModelState.IsValid)
            {
                db.Entry(выкройки).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_аксессуара = new SelectList(db.Аксессуары, "ID_аксессуара", "Наименование_аксессуара", выкройки.ID_аксессуара);
            ViewBag.ID_мерки = new SelectList(db.Мерки, "ID_мерки", "Примечания", выкройки.ID_мерки);
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", выкройки.ID_ткани);
            return View(выкройки);
        }

        //
        // GET: /Vikroiki/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Выкройки выкройки = db.Выкройки.Find(id);
            if (выкройки == null)
            {
                return HttpNotFound();
            }
            return View(выкройки);
        }

        //
        // POST: /Vikroiki/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Выкройки выкройки = db.Выкройки.Find(id);
            db.Выкройки.Remove(выкройки);
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