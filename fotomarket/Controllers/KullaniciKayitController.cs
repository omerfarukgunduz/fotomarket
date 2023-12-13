using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    [AllowAnonymous]

    public class KullaniciKayitController : Controller
    {
        // GET: KullaniciKayit
        fotomarketEntities data = new fotomarketEntities();
        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Table_Kullanicilar x)

        {
            data.Table_Kullanicilar.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}