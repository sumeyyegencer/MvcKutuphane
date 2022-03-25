using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MvcKutuphane.Controllers
{
    public class UyeController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Uye
        public ActionResult Index(int sayfa=1 )
        {
            var degerler = db.TBLUYELER.ToList().ToPagedList(sayfa, 3);

            //var degerler = db.TBLUYELER.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeEkle(TBLUYELER uye)
        {
            db.TBLUYELER.Add(uye);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult UyeSil(int id)
        {
            var item = db.TBLUYELER.Find(id);
            db.TBLUYELER.Remove(item);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult UyeGetir(int id)
        {
            var item = db.TBLUYELER.Find(id);
            return View("UyeGetir", item);
        }

        public ActionResult UyeGuncelle(TBLUYELER uye)
        {
           var item= db.TBLUYELER.Find(uye.ID);

            item.AD = uye.AD;
            item.SOYAD = uye.SOYAD;
            item.MAIL = uye.MAIL;
            item.KULLANICIADI = uye.KULLANICIADI;
            item.SIFRE = uye.SIFRE;
            item.FOTOGRAF = uye.FOTOGRAF;
            item.TELEFON = uye.TELEFON;
            item.OKUL = uye.OKUL;

            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}