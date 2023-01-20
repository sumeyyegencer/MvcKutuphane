using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using MvcKutuphane.Models.Classes;

namespace MvcKutuphane.Controllers
{
    public class IstatistikController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Istatistik
        public ActionResult Index()
        {


            var uye = db.TBLUYELER.Count();
            var kitap = db.TBLKITAP.Count();
            var emanet = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            var ceza = db.TBLCEZALAR.Sum(x => x.PARA);
            ViewBag.degerUye = uye;
            ViewBag.degerKitap = kitap;
            ViewBag.degerEmanet = emanet;
            ViewBag.degerCeza = ceza;
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

        public ActionResult LinqKartlar()
        {
            return View();
        }
    }
}