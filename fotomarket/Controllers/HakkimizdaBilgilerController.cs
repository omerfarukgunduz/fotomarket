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

    public class HakkimizdaBilgilerController : Controller
    {
        // GET: HakkimizdaBilgiler
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veri = data.Table_Hakkimizda.ToList();
            return View(veri);
        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var veriler = data.Table_Hakkimizda.Find(id);
            return View("HakkimizdaGetir", veriler);
        }

        public ActionResult HakkimizdaGuncelle(Table_Hakkimizda x)
        {
            var video = data.Table_Hakkimizda.Find(x.ID);
            video.KullaniciID = x.KullaniciID;
            video.HakkimizdaMetni = x.HakkimizdaMetni;
            data.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
