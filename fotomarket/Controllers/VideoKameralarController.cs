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

    public class VideoKameralarController : Controller
    {
        // GET: VideoKameralar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_VideoKameralar.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_VideoKameralar x)

        {
            data.Table_VideoKameralar.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = data.Table_VideoKameralar.Find(id);
            data.Table_VideoKameralar.Remove(urun);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = data.Table_VideoKameralar.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Table_VideoKameralar x)
        {
            var urun = data.Table_VideoKameralar.Find(x.ID);
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