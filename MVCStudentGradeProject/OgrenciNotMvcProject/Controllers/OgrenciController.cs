using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models.EntityFramework;

namespace OgrenciNotMvcProject.Controllers
{
    public class OgrenciController : Controller
    {
        DbMvcOkulEntities db = new DbMvcOkulEntities();

        // GET: Ogrenci
        public ActionResult Index()
        {
            var ogrenciler = db.TblOgrenciler.ToList();
            return View(ogrenciler);
        }

        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler = (from i in db.TblKulüpler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulüpAd,
                                                 Value = i.KulüpId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult YeniOgrenci(TblOgrenciler p)
        {
            var klp = db.TblKulüpler.Where(m => m.KulüpId == p.TblKulüpler.KulüpId).FirstOrDefault();
            p.TblKulüpler = klp;
            db.TblOgrenciler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var ogrrenci = db.TblOgrenciler.Find(id);
            db.TblOgrenciler.Remove(ogrrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = db.TblOgrenciler.Find(id);
            List<SelectListItem> degerler = (from i in db.TblKulüpler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulüpAd,
                                                 Value = i.KulüpId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("OgrenciGetir", ogrenci);
        }

        public ActionResult Guncelle(TblOgrenciler p)
        {
            var ogr = db.TblOgrenciler.Find(p.OgrId);
            ogr.OgrAd = p.OgrAd;
            ogr.OgrSoyad = p.OgrSoyad;
            ogr.OgrFoto = p.OgrFoto;
            ogr.OgrCinsiyet = p.OgrCinsiyet;
            ogr.OgrKulüp = p.OgrKulüp;
            db.SaveChanges();
            return RedirectToAction("Index", "Ogrenci");
        }

    }
}