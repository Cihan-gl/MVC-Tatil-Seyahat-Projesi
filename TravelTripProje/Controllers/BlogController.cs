using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {



        BlogYorum by = new BlogYorum();
        Context c = new Context();

        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger2 = c.Yorumlars.Take(3).OrderByDescending(b => b.Yorum).ToList();
            by.Deger3 = c.Blogs.Take(3).OrderByDescending(a => a.Baslik).ToList();
            return View(by);
        }



        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(o=>o.BlogID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(o => o.BlogID == id).ToList();

            return View(by);
        }
        


        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }



        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();

            return PartialView();
        }


    }
}