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
    public class BuhgalteriyaController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Buhgalteriya/

        public ActionResult Index()
        {
            //db.ProcedurExperience();
            //db.ProcedureSalary();
            db.SaveChanges();
            var бухгалтерия = db.Бухгалтерия.Include(б => б.Сотрудник);
            return View(бухгалтерия.ToList());
        }

        //
        // GET: /Buhgalteriya/Details/5

        public ActionResult Details(int id = 0)
        {
            Бухгалтерия бухгалтерия = db.Бухгалтерия.Find(id);
            if (бухгалтерия == null)
            {
                return HttpNotFound();
            }
            return View(бухгалтерия);
        }

        //
        // GET: /Buhgalteriya/Create

        public ActionResult Create()
        {
            db.ProcedurExperience();
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия");
            return View();
        }

        //
        // POST: /Buhgalteriya/Create

        [HttpPost]
        public ActionResult Create(Бухгалтерия бухгалтерия)
        {
            if (ModelState.IsValid)
            {
                db.Бухгалтерия.Add(бухгалтерия);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", бухгалтерия.ID_сотрудника);
            return View(бухгалтерия);
        }

        //
        // GET: /Buhgalteriya/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Бухгалтерия бухгалтерия = db.Бухгалтерия.Find(id);
            if (бухгалтерия == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", бухгалтерия.ID_сотрудника);
            return View(бухгалтерия);
        }

        //
        // POST: /Buhgalteriya/Edit/5

        [HttpPost]
        public ActionResult Edit(Бухгалтерия бухгалтерия)
        {
            if (ModelState.IsValid)
            {
                db.Entry(бухгалтерия).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_сотрудника = new SelectList(db.Сотрудник, "ID_сотрудника", "Фамилия", бухгалтерия.ID_сотрудника);
            return View(бухгалтерия);
        }

        //
        // GET: /Buhgalteriya/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Бухгалтерия бухгалтерия = db.Бухгалтерия.Find(id);
            if (бухгалтерия == null)
            {
                return HttpNotFound();
            }
            return View(бухгалтерия);
        }

        //
        // POST: /Buhgalteriya/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Бухгалтерия бухгалтерия = db.Бухгалтерия.Find(id);
            db.Бухгалтерия.Remove(бухгалтерия);
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