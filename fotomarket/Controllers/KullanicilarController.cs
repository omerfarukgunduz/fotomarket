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

    public class KullanicilarController : Controller
    {
        // GET: Kullanicilar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_Kullanicilar.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult KullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KullaniciEkle(Table_Kullanicilar x)

        {
            data.Table_Kullanicilar.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KullaniciGetir(int id)
        {
            var urun = data.Table_Kullanicilar.Find(id);
            return View("KullaniciGetir", urun);
        }

        public ActionResult KullaniciGuncelle(Table_Kullanicilar x)
        {
            var kullanici = data.Table_Kullanicilar.Find(x.ID);
            kullanici.KullanciAdi = x.KullanciAdi;
            kullanici.Eposta = x.Eposta;
            kullanici.AdSoyad = x.AdSoyad;
            kullanici.TC = x.TC;
            kullanici.CepTelefonu = x.CepTelefonu;
            kullanici.Rol = x.Rol;
            kullanici.Sifre = x.Sifre;
            data.SaveChanges();
            return RedirectToAction("Index");

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