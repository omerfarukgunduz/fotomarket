using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fotomarket.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        fotomarketEntities data = new fotomarketEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Table_Admin a)
        {
            var adminkullanici = data.Table_Admin.FirstOrDefault(x => x.AdminKullaniciAdi == a.AdminKullaniciAdi && x.Sifre == a.Sifre);
            if (adminkullanici != null)
            {
                FormsAuthentication.SetAuthCookie(adminkullanici.AdminKullaniciAdi, false);
                Session["AdminKullaniciAdi"] = adminkullanici.AdminKullaniciAdi.ToString();
                return RedirectToAction("Index", "DslrMakineler");
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "AdminLogin");
        }
    }
}