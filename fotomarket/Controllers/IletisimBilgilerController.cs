using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class IletisimBilgilerController : Controller
    {
        // GET: IletisimBilgiler
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veri = data.Table_IletisimBilgileri.ToList();
            return View(veri);
        }

        public ActionResult IletisimBilgileriGetir(int id)
        {
            var veriler = data.Table_IletisimBilgileri.Find(id);
            return View("IletisimBilgileriGetir", veriler);
        }

        public ActionResult IletisimBilgileriGuncelle(Table_IletisimBilgileri x)
        {
            var video = data.Table_IletisimBilgileri.Find(x.ID);
            video.AdminID = x.AdminID;
            video.TelefonNumarasi = x.TelefonNumarasi;
            video.EpostaAdresi = x.EpostaAdresi;
            data.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}