using fotomarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Controllers
{
    public class VideolarController : Controller
    {
        // GET: Videolar
        fotomarketEntities data = new fotomarketEntities();

        public ActionResult Index()
        {
            var videolar = data.Table_Videolar.ToList();
            return View(videolar);
        }
        public ActionResult VideoGetir(int id)
        {
            var video = data.Table_Videolar.Find(id);
            return View("VideoGetir", video);
        }

        public ActionResult VideoGuncelle(Table_Videolar x)
        {
            var video = data.Table_Videolar.Find(x.ID);
            video.AdminID = x.AdminID;
            video.VideoSrcLinki = x.VideoSrcLinki;
            data.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}