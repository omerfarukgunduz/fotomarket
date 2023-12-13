using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var linkler = data.Table_Kaynaklar.ToList();
            return View(linkler);
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


    }
}