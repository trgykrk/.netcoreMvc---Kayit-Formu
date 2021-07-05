using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcTask.Models
{
    public class Talepler
    {
        [Key]
        public int Talep_ID { get; set; }
        [Required(ErrorMessage = "Adınız Alanı Boş Bırakılamaz!!!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyadınız Alanı Boş Bırakılamaz!!!")]
        public string Soyad { get; set; }
        [Phone(ErrorMessage = "Telefon Numarası Sayılardan Oluşmalıdır!!!")]
        [MinLength(10, ErrorMessage = "Telefon Numarası Minimum 10 Hane Olmalıdır!!!")]
        [MaxLength(11, ErrorMessage = "Telefon Numarası Maxsimum 11 Hane Olmalıdır!!!")]
        public string İletisim { get; set; }
        [Required(ErrorMessage = "E-Posta Alanı boş Bırakılamaz !!!")]
        [EmailAddress(ErrorMessage = "Lütfen  Geçerli Bir Mail Adresi Giriniz!!!")]
        public string Eposta { get; set; }
        public string Mesaj { get; set; }
    }
}
