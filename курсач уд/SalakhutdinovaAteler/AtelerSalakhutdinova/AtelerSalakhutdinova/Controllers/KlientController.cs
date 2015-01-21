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
    public class KlientController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Klient/

        public ActionResult Index()
        {
            return View(db.Клиент.ToList());
        }

        //
        // GET: /Klient/Details/5

        public ActionResult Details(int id = 0)
        {
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            return View(клиент);
        }

        //
        // GET: /Klient/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Klient/Create

        [HttpPost]
        public ActionResult Create(Клиент клиент)
        {
            if (ModelState.IsValid)
            {
                db.Клиент.Add(клиент);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(клиент);
        }

        //
        // GET: /Klient/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            return View(клиент);
        }

        //
        // POST: /Klient/Edit/5

        [HttpPost]
        public ActionResult Edit(Клиент клиент)
        {
            if (ModelState.IsValid)
            {
                db.Entry(клиент).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(клиент);
        }

        //
        // GET: /Klient/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Клиент клиент = db.Клиент.Find(id);
            if (клиент == null)
            {
                return HttpNotFound();
            }
            return View(клиент);
        }

        //
        // POST: /Klient/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Клиент клиент = db.Клиент.Find(id);
            db.Клиент.Remove(клиент);
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