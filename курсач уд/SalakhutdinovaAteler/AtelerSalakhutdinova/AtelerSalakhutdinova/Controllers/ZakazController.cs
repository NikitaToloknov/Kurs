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
    public class ZakazController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Zakaz/

        public ActionResult Index()
        {
            var заказ = db.Заказ.Include(з => з.Выкройки).Include(з => з.Доставка).Include(з => з.Клиент).Include(з => з.Состояние);
            return View(заказ.ToList());
        }

        //
        // GET: /Zakaz/Details/5

        public ActionResult Details(int id = 0)
        {
            Заказ заказ = db.Заказ.Find(id);
            if (заказ == null)
            {
                return HttpNotFound();
            }
            return View(заказ);
        }

        //
        // GET: /Zakaz/Create

        public ActionResult Create()
        {
            ViewBag.ID_выкройки = new SelectList(db.Выкройки, "ID_выкройки", "Модель");
            ViewBag.ID_доставки = new SelectList(db.Доставка, "ID_доставки", "ID_доставки");
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия");
            ViewBag.ID_заказа = new SelectList(db.Состояние, "ID_заказа", "Примечания");
            return View();
        }

        //
        // POST: /Zakaz/Create

        [HttpPost]
        public ActionResult Create(Заказ заказ)
        {
            if (ModelState.IsValid)
            {
                db.Заказ.Add(заказ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_выкройки = new SelectList(db.Выкройки, "ID_выкройки", "Модель", заказ.ID_выкройки);
            ViewBag.ID_доставки = new SelectList(db.Доставка, "ID_доставки", "ID_доставки", заказ.ID_доставки);
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", заказ.ID_заказчика);
            ViewBag.ID_заказа = new SelectList(db.Состояние, "ID_заказа", "Примечания", заказ.ID_заказа);
            return View(заказ);
        }

        //
        // GET: /Zakaz/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Заказ заказ = db.Заказ.Find(id);
            if (заказ == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_выкройки = new SelectList(db.Выкройки, "ID_выкройки", "Модель", заказ.ID_выкройки);
            ViewBag.ID_доставки = new SelectList(db.Доставка, "ID_доставки", "ID_доставки", заказ.ID_доставки);
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", заказ.ID_заказчика);
            ViewBag.ID_заказа = new SelectList(db.Состояние, "ID_заказа", "Примечания", заказ.ID_заказа);
            return View(заказ);
        }

        //
        // POST: /Zakaz/Edit/5

        [HttpPost]
        public ActionResult Edit(Заказ заказ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(заказ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_выкройки = new SelectList(db.Выкройки, "ID_выкройки", "Модель", заказ.ID_выкройки);
            ViewBag.ID_доставки = new SelectList(db.Доставка, "ID_доставки", "ID_доставки", заказ.ID_доставки);
            ViewBag.ID_заказчика = new SelectList(db.Клиент, "ID_заказчика", "Фамилия", заказ.ID_заказчика);
            ViewBag.ID_заказа = new SelectList(db.Состояние, "ID_заказа", "Примечания", заказ.ID_заказа);
            return View(заказ);
        }

        //
        // GET: /Zakaz/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Заказ заказ = db.Заказ.Find(id);
            if (заказ == null)
            {
                return HttpNotFound();
            }
            return View(заказ);
        }

        //
        // POST: /Zakaz/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Заказ заказ = db.Заказ.Find(id);
            db.Заказ.Remove(заказ);
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