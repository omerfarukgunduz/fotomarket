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
    public class AksiyonKameralariController : Controller
    {
        // GET: AksiyonKameralari
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_AksiyonKameralari.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_AksiyonKameralari x)

        {
            data.Table_AksiyonKameralari.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = data.Table_AksiyonKameralari.Find(id);
            data.Table_AksiyonKameralari.Remove(urun);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = data.Table_AksiyonKameralari.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Table_AksiyonKameralari x)
        {
            var urun = data.Table_AksiyonKameralari.Find(x.ID);
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