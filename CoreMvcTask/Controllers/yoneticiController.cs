using CoreMvcTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Controllers
{
    [Authorize]
    public class yoneticiController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler=c.kullanicilars.ToList();
            return View(degerler);
        }

        public IActionResult MesajListesi()
        {
            var mesajlar = c.taleplers.ToList();
            return View(mesajlar);
        }

        public IActionResult TalepListesi()
        {
           
            var talepler = c.musterilers.ToList();
            return View(talepler);
        }
        [HttpGet]
        public IActionResult YeniKullanici()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKullanici(Kullanicilar k)
        {
            c.kullanicilars.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult KullaniciSil(int id)
        {
            var kullanici = c.kullanicilars.Find(id);
            c.kullanicilars.Remove(kullanici);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult KullaniciGetir(int id)
        {
            var kullanici = c.kullanicilars.Find(id);
            return View("KullaniciGetir",kullanici);
        }

        public IActionResult KullaniciGüncelle(Kullanicilar k)
        {
            var kullanici = c.kullanicilars.Find(k.Kullanici_ID);
            kullanici.Kullanici_Adi = k.Kullanici_Adi;
            kullanici.Sifre = k.Sifre;
            kullanici.Yetki_Kodu = k.Yetki_Kodu;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

      
    }
}
