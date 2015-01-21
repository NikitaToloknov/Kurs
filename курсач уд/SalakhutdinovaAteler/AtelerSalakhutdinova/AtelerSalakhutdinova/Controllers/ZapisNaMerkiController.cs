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
    public class ZapisNaMerkiController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /ZapisNaMerki/

        public ActionResult Index()
        {
            var записьнамерку = db.ЗаписьНаМерку.Include(з => з.Клиент);
            return View(записьнамерку.ToList());
        }

        //
        // GET: /ZapisNaMerki/Details/5

        public ActionResult Details(int id = 0)
        {
            ЗаписьНаМерку записьнамерку = db.ЗаписьНаМерку.Find(id);
            if (записьнамерку == null)
            {
                return HttpNotFound();
            }
            return View(записьнамерку);
        }

        //
        // GET: /ZapisNaMerki/Create

        public ActionResult Create()
        {
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия");
            return View();
        }

        //
        // POST: /ZapisNaMerki/Create

        [HttpPost]
        public ActionResult Create(ЗаписьНаМерку записьнамерку)
        {
            if (ModelState.IsValid)
            {
                db.ЗаписьНаМерку.Add(записьнамерку);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", записьнамерку.ID_заказчика);
            return View(записьнамерку);
        }

        //
        // GET: /ZapisNaMerki/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ЗаписьНаМерку записьнамерку = db.ЗаписьНаМерку.Find(id);
            if (записьнамерку == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", записьнамерку.ID_заказчика);
            return View(записьнамерку);
        }

        //
        // POST: /ZapisNaMerki/Edit/5

        [HttpPost]
        public ActionResult Edit(ЗаписьНаМерку записьнамерку)
        {
            if (ModelState.IsValid)
            {
                db.Entry(записьнамерку).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", записьнамерку.ID_заказчика);
            return View(записьнамерку);
        }

        //
        // GET: /ZapisNaMerki/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ЗаписьНаМерку записьнамерку = db.ЗаписьНаМерку.Find(id);
            if (записьнамерку == null)
            {
                return HttpNotFound();
            }
            return View(записьнамерку);
        }

        //
        // POST: /ZapisNaMerki/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ЗаписьНаМерку записьнамерку = db.ЗаписьНаМерку.Find(id);
            db.ЗаписьНаМерку.Remove(записьнамерку);
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