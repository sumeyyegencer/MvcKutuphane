using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KayıtOlController : Controller
    {
        // GET: KayıtOl
        public ActionResult Kayıt()
        {
            return View();
        }
    }
}