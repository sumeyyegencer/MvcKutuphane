using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hava()
        {
            return View();
        }

        public ActionResult HavaKart()
        {
            return View();
        }

        public ActionResult Galeri()
        {
            return View();
        }

        public ActionResult resimyükle(HttpPostedFileBase dosya)
        {
            if(dosya.ContentLength>0)
            {
                string dosyaYolu = Path.Combine(Server.MapPath("~/Content/assets/"), Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyaYolu);
            }

            return RedirectToAction("Index");
        }
    }
}