using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvcProject.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(int sayi1=0, int sayi2=0)
        {
            int sonuç = sayi1 + sayi2;
            ViewBag.snc = sonuç;
            return View();
        }
    }
}