using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class MesajlarController : Controller
    {
        // GET: Mesajlar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var mesajlar = data.Table_Iletisim.ToList();
            return View(mesajlar);
        }

        public ActionResult MesajSil(int id)
        {
            var mesaj = data.Table_Iletisim.Find(id);
            data.Table_Iletisim.Remove(mesaj);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}