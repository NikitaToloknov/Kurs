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
    public class SkladController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Sklad/

        public ActionResult Index()
        {
            var складтканей = db.СкладТканей.Include(с => с.СведенияОТканях);
            return View(складтканей.ToList());
        }

        //
        // GET: /Sklad/Details/5

        public ActionResult Details(int id = 0)
        {
            СкладТканей складтканей = db.СкладТканей.Find(id);
            if (складтканей == null)
            {
                return HttpNotFound();
            }
            return View(складтканей);
        }

        //
        // GET: /Sklad/Create

        public ActionResult Create()
        {
            ViewBag.ID_ткани = new SelectList(db.СведенияОТканях, "ID_ткани", "Страна_производитель");
            return View();
        }

        //
        // POST: /Sklad/Create

        [HttpPost]
        public ActionResult Create(СкладТканей складтканей)
        {
            if (ModelState.IsValid)
            {
                db.СкладТканей.Add(складтканей);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ткани = new SelectList(db.СведенияОТканях, "ID_ткани", "Страна_производитель", складтканей.ID_ткани);
            return View(складтканей);
        }

        //
        // GET: /Sklad/Edit/5

        public ActionResult Edit(int id = 0)
        {
            СкладТканей складтканей = db.СкладТканей.Find(id);
            if (складтканей == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ткани = new SelectList(db.СведенияОТканях, "ID_ткани", "Страна_производитель", складтканей.ID_ткани);
            return View(складтканей);
        }

        //
        // POST: /Sklad/Edit/5

        [HttpPost]
        public ActionResult Edit(СкладТканей складтканей)
        {
            if (ModelState.IsValid)
            {
                db.Entry(складтканей).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ткани = new SelectList(db.СведенияОТканях, "ID_ткани", "Страна_производитель", складтканей.ID_ткани);
            return View(складтканей);
        }

        //
        // GET: /Sklad/Delete/5

        public ActionResult Delete(int id = 0)
        {
            СкладТканей складтканей = db.СкладТканей.Find(id);
            if (складтканей == null)
            {
                return HttpNotFound();
            }
            return View(складтканей);
        }

        //
        // POST: /Sklad/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            СкладТканей складтканей = db.СкладТканей.Find(id);
            db.СкладТканей.Remove(складтканей);
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