using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class AdminlerController : Controller
    {
        // GET: Adminler
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var veriler = data.Table_Admin.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Table_Admin x)

        {
            data.Table_Admin.Add(x);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult AdminGetir(int id)
        {
            var urun = data.Table_Admin.Find(id);
            return View("AdminGetir", urun);
        }

        public ActionResult AdminGuncelle(Table_Admin x)
        {
            var admin = data.Table_Admin.Find(x.ID);
            admin.AdminKullaniciAdi=x.AdminKullaniciAdi;
            admin.Sifre=x.Sifre;
            data.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult AdminSil(int id)
        {
            if (id == 1)
            {
                
                return RedirectToAction("Index");
            }

            var admin = data.Table_Admin.Find(id);
            if (admin != null)
            {
                data.Table_Admin.Remove(admin);
                data.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        //public ActionResult AdminSil(int id)
        //{
        //    var admin = data.Table_Admin.Find(id);
        //    data.Table_Admin.Remove(admin);
        //    data.SaveChanges();
        //    return RedirectToAction("Index");
        //}

    }
}