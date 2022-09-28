using MvcProjeKamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(Bloglist(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> Bloglist()
        {
            List<CategoryClass> categoryClasses = new List<CategoryClass>();
            categoryClasses.Add(new CategoryClass()
            { 
                CategoryName="Yazılım",
                CategoryCount= 9
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Gezi",
                CategoryCount= 3
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 7
            });
            categoryClasses.Add(new CategoryClass()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 6
            });
            return categoryClasses;
        }
    }
}