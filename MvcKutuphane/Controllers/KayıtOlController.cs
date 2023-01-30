using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KayıtOlController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: KayıtOl
        public ActionResult Kayıt()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Kayıt(TBLUYELER p)
        {
            if(!ModelState.IsValid)
            {
                return View("Kayıt");
            }

            db.TBLUYELER.Add(p);
            db.SaveChanges();

            return View();
        }
    }
}