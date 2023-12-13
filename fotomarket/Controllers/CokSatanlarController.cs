using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class CokSatanlarController : Controller
    {
        // GET: CokSatanlar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_CokSatanlar.ToList();
            return View(veriler);
        }
        public ActionResult UrunGetir(Guid id)
        {
            var urun = data.Table_CokSatanlar.Find(id);
            return View("UrunGetir", urun);
        }
       
        public ActionResult UrunGuncelle(Table_CokSatanlar x)
        {
            var urun = data.Table_CokSatanlar.Find(x.ID);
            urun.UrunID = x.UrunID;
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