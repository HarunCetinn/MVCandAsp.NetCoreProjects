using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models;
using OgrenciNotMvcProject.Models.EntityFramework;

namespace OgrenciNotMvcProject.Controllers
{
    public class NotlarController : Controller
    {
        DbMvcOkulEntities db = new DbMvcOkulEntities();

        // GET: Notlar
        public ActionResult Index()
        {
            var SinavNotlar = db.TblNotlar.ToList();
            return View(SinavNotlar);
        }

        [HttpGet]
        public ActionResult YeniSınav()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSınav(TblNotlar tbn)
        {
            db.TblNotlar.Add(tbn);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult NotGetir(int id)
        {
            var notlar = db.TblNotlar.Find(id);
            return View("NotGetir", notlar);
        }

        [HttpPost]
        public ActionResult NotGetir(Class1 model, TblNotlar p,int Sınav1=0, int Sınav2 = 0, int Sınav3 = 0, int Proje = 0)
        {
            if (model.Islem == "Hesapla")
            {
                //İşlem1
                int ortalama = (Sınav1 + Sınav2 + Sınav3 + Proje) / 4;
                ViewBag.ort = ortalama;
            }
            if (model.Islem == "NotGuncelle")
            {
                //İşlem2
                var snv = db.TblNotlar.Find(p.NotId);
                snv.Sınav1 = p.Sınav1;
                snv.Sınav2 = p.Sınav2;
                snv.Sınav3 = p.Sınav3;
                snv.Proje = p.Proje;
                snv.Ortalama = p.Ortalama;
                db.SaveChanges();
                return RedirectToAction("Index", "Notlar");
            }
            return View();
        }
    }
}