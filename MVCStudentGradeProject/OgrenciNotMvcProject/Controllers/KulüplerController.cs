using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models.EntityFramework;

namespace OgrenciNotMvcProject.Controllers
{
    public class KulüplerController : Controller
    {
        DbMvcOkulEntities db = new DbMvcOkulEntities();

        // GET: Kulüpler
        public ActionResult Index()
        {
            var kulüpler = db.TblKulüpler.ToList();
            return View(kulüpler);
        }

        [HttpGet]
        public ActionResult YeniKulüp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKulüp(TblKulüpler p)
        {
            db.TblKulüpler.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var kulup = db.TblKulüpler.Find(id);
            db.TblKulüpler.Remove(kulup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KulüpGetir(int id)
        {
            var kulup = db.TblKulüpler.Find(id);
            return View("KulüpGetir",kulup);
        }

        public ActionResult Guncelle(TblKulüpler p)
        {
            var klp = db.TblKulüpler.Find(p.KulüpId);
            klp.KulüpAd = p.KulüpAd;
            db.SaveChanges();
            return RedirectToAction("Index", "Kulüpler");
        }
    }
}