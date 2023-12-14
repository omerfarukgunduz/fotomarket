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

    public class DronelarController : Controller
    {
        // GET: Dronelar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_Dronelar.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_Dronelar x)

        {
            data.Table_Dronelar.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = data.Table_Dronelar.Find(id);
            data.Table_Dronelar.Remove(urun);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = data.Table_Dronelar.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Table_Dronelar x)
        {
            var urun = data.Table_Dronelar.Find(x.ID);
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