using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
       Context bg = new Context();

        public ActionResult Index()
        {
            var degerler = bg.Blogs.Take(3).ToList();
            return View(degerler);
        }



        public PartialViewResult Partial1()
        {
           
            var degerler = bg.Blogs.Where(o => o.BlogID >= 2).OrderByDescending(o => o.BlogID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = bg.Blogs.Where(o => o.BlogID == 1).ToList();
            return PartialView(deger);
        }



        public PartialViewResult Partial3()
        {
            var deger = bg.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = bg.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
           
            var deger = bg.Blogs.OrderByDescending(o => o.BlogID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}