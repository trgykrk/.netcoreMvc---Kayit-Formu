using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcTask.Models;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcTask.Controllers
{
    public class MusteriPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        Context c = new Context();

        [HttpGet]
        public IActionResult MesajOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MesajOlustur(Talepler t)
        {
            if (!ModelState.IsValid)
            {
                return View("MesajOlustur");
            }

            c.taleplers.Add(t);
            c.SaveChanges();
            TempData["Basarili"] = "En kısa zamanda ekibimiz  tarafınıza dönüş yapacaktır.";
            return RedirectToAction("MesajOlustur");
            

        }
        [HttpGet]
        public IActionResult TalepOlustur()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult TalepOlustur(LogoEkle  L)
        {
            if (!ModelState.IsValid)
            {
                return View("TalepOlustur");
            }

        Musteriler m = new Musteriler();
            if (L.Firma_Logo !=null)
            {
                var extension = Path.GetExtension(L.Firma_Logo.FileName);
                var logo = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/Logolar/", logo);
                var stream = new FileStream(location, FileMode.Create);
                L.Firma_Logo.CopyTo(stream);
                m.Firma_Logo = logo;
                m.Adi = L.Adi;
                m.Soyadi = L.Soyadi;
                m.iletisim = L.iletisim;
                m.eposta = L.eposta;
                m.Domain_Adi = L.Domain_Adi;
                m.Domain_Sure = L.Domain_Sure;
                m.Aciklama = L.Aciklama;
                m.Uzanti_Adi = L.Uzanti_Adi;
                m.Urun_Adi = L.Urun_Adi;
                c.musterilers.Add(m);
                c.SaveChanges();
                TempData["Basarili"] = "En kısa zamanda ekibimiz tarafınıza dönüş yapacaktır.";
                return RedirectToAction("TalepOlustur");

            }

            m.Adi = L.Adi;
            m.Soyadi = L.Soyadi;
            m.iletisim = L.iletisim;
            m.eposta = L.eposta;
            m.Domain_Adi = L.Domain_Adi;
            m.Domain_Sure = L.Domain_Sure;
            m.Aciklama = L.Aciklama;
            m.Uzanti_Adi = L.Uzanti_Adi;
            m.Urun_Adi = L.Urun_Adi;
            c.musterilers.Add(m);
            c.SaveChanges();
            TempData["Basarili"] = "En kısa zamanda ekibimiz tarafınıza dönüş yapacaktır.";
            return RedirectToAction("TalepOlustur");

        }
    }
}
