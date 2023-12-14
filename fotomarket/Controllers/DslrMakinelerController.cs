using fotomarket.Attribute;
using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    [AdminAuthorizeAttribute]

    public class DslrMakinelerController : Controller
    {
        // GET: DslrMakineler
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_DSLRFotografMakineleri.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_DSLRFotografMakineleri x)

        {
            data.Table_DSLRFotografMakineleri.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = data.Table_DSLRFotografMakineleri.Find(id);
            data.Table_DSLRFotografMakineleri.Remove(urun);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = data.Table_DSLRFotografMakineleri.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Table_DSLRFotografMakineleri x)
        {
            var urun = data.Table_DSLRFotografMakineleri.Find(x.ID);
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