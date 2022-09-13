using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();


        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }


        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BlogSil(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGetir", blog);
        }


        //[HttpPut]
        public ActionResult BlogGüncelle(Blog blog)
        {
            var blg = c.Blogs.Find(blog.BlogID);
            blg.Aciklama = blog.Aciklama;
            blg.Baslik = blog.Baslik;
            blg.BlogImage = blog.BlogImage;
            blg.Tarih = blog.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }


        public ActionResult YorumSil(int id)
        {
            var deger = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            return View("YorumGetir",yorum);
        }


        public ActionResult YorumGüncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi= y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }



    }
}