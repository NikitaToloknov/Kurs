using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtelerSalakhutdinova.Models;

namespace AtelerSalakhutdinova.Controllers
{
    public class HomeController : Controller
    {
        private AtelierEntities db = new AtelierEntities();
        // GET: /Home/

        public ActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Index(AtelerSalakhutdinova.Models.Клиент KlModel)
        {
            //if (Session.GetUser() != null)
            //    throw new HttpException(404, "Not found");
            AtelerSalakhutdinova.Models.Сотрудник SotModel;
            var q = from u in db.Клиент where ((u.E_mail == KlModel.E_mail) && (u.Password == KlModel.Password)) select u;
            if (q.Count() == 0)
            {
                var s = from u in db.Сотрудник where ((u.E_mail == KlModel.E_mail) && (u.Password == KlModel.Password)) select u;
                SotModel = s.First();
                if (s.Count() == 0)
                    throw new HttpException(404, "Not found");
                    if( SotModel.Доступ_ко_всем_данным==true)
                        return RedirectToAction("Admin", "Roles");
                else
                    return  RedirectToAction("Sotrudnik", "Roles");

            }
            else
                return RedirectToAction("Klient", "Roles");
            return View();
        }

    }
}
