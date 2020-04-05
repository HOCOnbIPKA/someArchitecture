using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using core;
using infrastructure;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.Cci;

namespace web
{
    public class HomeController: Controller
    {
        IUnit unit;

        public HomeController(IUnit unit)
        {
            this.unit = unit;
        }
        public ActionResult Index()
        {
            var empl = unit.ElementRepository.Get();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Element el = unit.ElementRepository.GetElement(id);
            if (el == null)
            {
                return HttpNotFound();
            }
            return View(el);
        }
    }
}