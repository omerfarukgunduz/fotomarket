using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class KullanicilarController : Controller
    {
        // GET: Kullanicilar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_Kullanicilar.ToList();
            return View(veriler);
        }

        public ActionResult KullaniciSil(int id)
        {
            var kullanici = data.Table_Kullanicilar.Find(id);
            data.Table_Kullanicilar.Remove(kullanici);
            data.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}