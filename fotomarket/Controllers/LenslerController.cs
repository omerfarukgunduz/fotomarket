using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class LenslerController : Controller
    {
        // GET: Lensler
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_Lensler.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_Lensler x)

        {
            data.Table_Lensler.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = data.Table_Lensler.Find(id);
            data.Table_Lensler.Remove(urun);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = data.Table_Lensler.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Table_Lensler x)
        {
            var urun = data.Table_Lensler.Find(x.ID);
            urun.MarkaID = x.MarkaID;
            urun.MarkaAdi = x.MarkaAdi;
            urun.ModelAdi = x.ModelAdi;
            urun.UrunFiyati = x.UrunFiyati;
            urun.UrunGorseli = x.UrunGorseli;
            data.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}