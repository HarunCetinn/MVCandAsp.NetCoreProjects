using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        //[Authorize]
        public IActionResult Index()
        {
            var degerler = c.personels.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmanAd,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }


        public IActionResult YeniPersonel(Personel p)
        {
            var per = c.departmanlars.Where(x => x.Id == p.depart.Id).FirstOrDefault();
            p.depart = per;
            c.personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}