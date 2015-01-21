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
    public class SvedeniyaController : Controller
    {
        private AtelierEntities db = new AtelierEntities();

        //
        // GET: /Svedeniya/

        public ActionResult Index()
        {
            var сведенияотканях = db.СведенияОТканях.Include(с => с.СкладТканей);
            return View(сведенияотканях.ToList());
        }

        //
        // GET: /Svedeniya/Details/5

        public ActionResult Details(int id = 0)
        {
            СведенияОТканях сведенияотканях = db.СведенияОТканях.Find(id);
            if (сведенияотканях == null)
            {
                return HttpNotFound();
            }
            return View(сведенияотканях);
        }

        //
        // GET: /Svedeniya/Create

        public ActionResult Create()
        {
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани");
            return View();
        }

        //
        // POST: /Svedeniya/Create

        [HttpPost]
        public ActionResult Create(СведенияОТканях сведенияотканях)
        {
            if (ModelState.IsValid)
            {
                db.СведенияОТканях.Add(сведенияотканях);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", сведенияотканях.ID_ткани);
            return View(сведенияотканях);
        }

        //
        // GET: /Svedeniya/Edit/5

        public ActionResult Edit(int id = 0)
        {
            СведенияОТканях сведенияотканях = db.СведенияОТканях.Find(id);
            if (сведенияотканях == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", сведенияотканях.ID_ткани);
            return View(сведенияотканях);
        }

        //
        // POST: /Svedeniya/Edit/5

        [HttpPost]
        public ActionResult Edit(СведенияОТканях сведенияотканях)
        {
            if (ModelState.IsValid)
            {
                db.Entry(сведенияотканях).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ткани = new SelectList(db.СкладТканей, "ID_ткани", "Наименование_ткани", сведенияотканях.ID_ткани);
            return View(сведенияотканях);
        }

        //
        // GET: /Svedeniya/Delete/5

        public ActionResult Delete(int id = 0)
        {
            СведенияОТканях сведенияотканях = db.СведенияОТканях.Find(id);
            if (сведенияотканях == null)
            {
                return HttpNotFound();
            }
            return View(сведенияотканях);
        }

        //
        // POST: /Svedeniya/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            СведенияОТканях сведенияотканях = db.СведенияОТканях.Find(id);
            db.СведенияОТканях.Remove(сведенияотканях);
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