using Manual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manual.Controllers
{
    public class FichasController : Controller
    {
        private ManualContext db = new ManualContext();

        // GET: Ficha
        [HttpGet]
        public ActionResult vistaFichas()
        {
            return View(db.Fichas.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ficha ficha)
        {
            if (!ModelState.IsValid)
            {
                return View(ficha);
            }
            db.Fichas.Add(ficha);
            db.SaveChanges();
            return RedirectToAction("vistaFichas");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}