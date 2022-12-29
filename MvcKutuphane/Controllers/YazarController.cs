using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class YazarController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Yazar
        public ActionResult Index()
        {

            
            var degerler = db.TBLYAZAR.ToList();

            return View(degerler);
        }


        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YazarEkle(TBLYAZAR p)
        {
            if(!ModelState.IsValid)
            {

                return View("YazarEkle");
            }

            db.TBLYAZAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult YazarSil(int id)
        {
            var yazar= db.TBLYAZAR.Find(id);
            db.TBLYAZAR.Remove(yazar);

            db.SaveChanges();

            return RedirectToAction("Index");


        }


        public ActionResult YazarGetir(int id)
        {
            var yzr = db.TBLYAZAR.Find(id);
            return View("YazarGetir",yzr); // YazarGetir actionResult altındaki yzr e ait bilgileri getir.
        }


        public ActionResult YazarGüncelle(TBLYAZAR p)
        {
            var yzr=db.TBLYAZAR.Find(p.ID);
            yzr.AD = p.AD;
            yzr.SOYAD = p.SOYAD;
            yzr.DETAY = p.DETAY;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}