using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Models
{
    public class LogoEkle
    {
        public int Musterı_ID { get; set; }
        [Required(ErrorMessage = "Adınız Alanı Boş Bırakılamaz!!!")]
        public string Adi { get; set; }
        [Required(ErrorMessage = "Soyadınız Alanı Boş Bırakılamaz!!!")]
        public string Soyadi { get; set; }
        [Phone(ErrorMessage ="Telefon Numarası Sayılardan Oluşmalıdır!!!")]
        [MinLength(10,ErrorMessage ="Telefon Numarası Minimum 10 Hane Olmalıdır!!!")]
        [MaxLength(11,ErrorMessage = "Telefon Numarası Maxsimum 11 Hane Olmalıdır!!!")]
        public string iletisim { get; set; }
        [Required(ErrorMessage = "E-Posta Alanı boş Bırakılamaz !!!")]
        [EmailAddress(ErrorMessage ="Lütfen  Geçerli Bir Mail Adresi Giriniz!!!")]
        public string eposta { get; set; }
        [Required(ErrorMessage = "Domain Adı Alanı Boş Bırakılamaz!!!")]
        public string Domain_Adi { get; set; }
        public int Domain_Sure { get; set; }
        public IFormFile Firma_Logo { get; set; }
        [MaxLength(50,ErrorMessage ="100 Karekteri Geçmeyiniz!!!")]
        public string Aciklama { get; set; }
        public string Urun_Adi { get; set; }
        public string Uzanti_Adi { get; set; }
        public Uzantilar uzanti { get; set; }
    }
}
