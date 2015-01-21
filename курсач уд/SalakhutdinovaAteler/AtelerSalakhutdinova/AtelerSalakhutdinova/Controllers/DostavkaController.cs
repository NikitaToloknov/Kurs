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
    public class DostavkaController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Dostavka/

        public ActionResult Index()
        {
            var доставка = db.Доставка.Include(д => д.Сотрудник);
            return View(доставка.ToList());
        }

        //
        // GET: /Dostavka/Details/5

        public ActionResult Details(int id = 0)
        {
            Доставка доставка = db.Доставка.Find(id);
            if (доставка == null)
            {
                return HttpNotFound();
            }
            return View(доставка);
        }

        //
        // GET: /Dostavka/Create

        public ActionResult Create()
        {
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия");
            return View();
        }

        //
        // POST: /Dostavka/Create

        [HttpPost]
        public ActionResult Create(Доставка доставка)
        {
            if (ModelState.IsValid)
            {
                db.Доставка.Add(доставка);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", доставка.ID_сотрудника);
            return View(доставка);
        }

        //
        // GET: /Dostavka/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Доставка доставка = db.Доставка.Find(id);
            if (доставка == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", доставка.ID_сотрудника);
            return View(доставка);
        }

        //
        // POST: /Dostavka/Edit/5

        [HttpPost]
        public ActionResult Edit(Доставка доставка)
        {
            if (ModelState.IsValid)
            {
                db.Entry(доставка).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", доставка.ID_сотрудника);
            return View(доставка);
        }

        //
        // GET: /Dostavka/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Доставка доставка = db.Доставка.Find(id);
            if (доставка == null)
            {
                return HttpNotFound();
            }
            return View(доставка);
        }

        //
        // POST: /Dostavka/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Доставка доставка = db.Доставка.Find(id);
            db.Доставка.Remove(доставка);
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