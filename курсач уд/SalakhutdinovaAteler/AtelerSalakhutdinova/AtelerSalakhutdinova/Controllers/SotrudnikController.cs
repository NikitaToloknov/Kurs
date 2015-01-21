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
    public class SotrudnikController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Sotrudnik/

        public ActionResult Index()
        {
            
            return View(db.Сотрудник.ToList());
        }

        //
        // GET: /Sotrudnik/Details/5

        public ActionResult Details(int id = 0)
        {
            Сотрудник сотрудник = db.Сотрудник.Find(id);
            if (сотрудник == null)
            {
                return HttpNotFound();
            }
            return View(сотрудник);
        }

        //
        // GET: /Sotrudnik/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sotrudnik/Create

        [HttpPost]
        public ActionResult Create(Сотрудник сотрудник)
        {
            if (ModelState.IsValid)
            {
                db.Сотрудник.Add(сотрудник);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(сотрудник);
        }

        //
        // GET: /Sotrudnik/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Сотрудник сотрудник = db.Сотрудник.Find(id);
            if (сотрудник == null)
            {
                return HttpNotFound();
            }
            return View(сотрудник);
        }

        //
        // POST: /Sotrudnik/Edit/5

        [HttpPost]
        public ActionResult Edit(Сотрудник сотрудник)
        {
            if (ModelState.IsValid)
            {
                db.Entry(сотрудник).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(сотрудник);
        }

        //
        // GET: /Sotrudnik/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Сотрудник сотрудник = db.Сотрудник.Find(id);
            if (сотрудник == null)
            {
                return HttpNotFound();
            }
            return View(сотрудник);
        }

        //
        // POST: /Sotrudnik/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Сотрудник сотрудник = db.Сотрудник.Find(id);
            db.Сотрудник.Remove(сотрудник);
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