using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fotomarket.Controllers
{
    public class KullaniciLoginController : Controller
    {
        // GET: KullaniciLogin
        fotomarketEntities data = new fotomarketEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Table_Kullanicilar k)
        {
            var kullanici = data.Table_Kullanicilar.FirstOrDefault(x => x.Eposta == x.Eposta && x.Sifre == x.Sifre);
            if (kullanici != null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.Eposta, false);
                Session["Eposta"] = kullanici.Eposta.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index","KullaniciLogin");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
