using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        fotomarketEntities data = new fotomarketEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult VideolarPartial()
        {
            var veriler=data.Table_Videolar.ToList();
            return PartialView(veriler);
        }
       
        public PartialViewResult CokSatanlarPartial() 
        {
        var veriler=data.Table_CokSatanlar.ToList();
            return PartialView(veriler);
        }

        public PartialViewResult HakkimizdaPartial() 
        {
            var veriler = data.Table_Hakkimizda.ToList();
            return PartialView(veriler);
        }

        public PartialViewResult IletisimBilgileriPartial() 
        {
            var veriler = data.Table_IletisimBilgileri.ToList();
            return PartialView(veriler);

        }

        [HttpGet]
        public PartialViewResult IletisimPartial()
        {
        return PartialView();
        }
        [HttpPost]
        public PartialViewResult IletisimPartial(Table_Iletisim i)
        {
            data.Table_Iletisim.Add(i);
            data.SaveChanges();
            return PartialView();
        }

        public ActionResult DslrFotografMakineleri()
        {
            var veriler = data.Table_DSLRFotografMakineleri.ToList();
            return View(veriler);
        }
        public ActionResult AynasizFotografMakineleri()
        {
            var veriler = data.Table_AynasizFotografMakineleri.ToList();
            return View(veriler);
        }

        public ActionResult VideoKameralar()
        {
            var veriler = data.Table_VideoKameralar.ToList();
            return View(veriler);
        }

        public ActionResult Lensler()
        {
            var veriler = data.Table_Lensler.ToList();
            return View(veriler);
        }

        public ActionResult Dronelar()
        {
            var veriler = data.Table_Dronelar.ToList();
            return View(veriler);
        }

        public ActionResult AksiyonKameralari()
        {
            var veriler = data.Table_AksiyonKameralari.ToList();
            return View(veriler);
        }
    }
}