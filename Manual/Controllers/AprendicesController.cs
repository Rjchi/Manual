using Manual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manual.Controllers
{
    public class AprendicesController : Controller
    {
        private ManualContext db = new ManualContext();
        // GET: Aprendiz
        public ActionResult vistaAprendices()
        {
            return View();
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