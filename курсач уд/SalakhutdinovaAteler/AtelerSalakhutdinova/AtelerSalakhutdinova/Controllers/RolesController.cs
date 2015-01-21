using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtelerSalakhutdinova.Models;


namespace AtelerSalakhutdinova.Controllers
{
    public class RolesController : Controller
    {
        //
        // GET: /Roles/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Klient()
        {
            return View();
        }
        public ActionResult Sotrudnik()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }


    }
}
