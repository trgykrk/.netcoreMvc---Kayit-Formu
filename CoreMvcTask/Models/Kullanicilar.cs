using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcTask.Models
{
    public class Kullanicilar
    {
        [Key]
        public int Kullanici_ID { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
        public int Yetki_Kodu { get; set; }


    }
}
