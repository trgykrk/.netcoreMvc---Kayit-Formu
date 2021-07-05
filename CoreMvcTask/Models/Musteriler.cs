using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcTask.Models
{
    public class Musteriler
    {
        [Key]
        public int Musterı_ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string iletisim { get; set; }
        public string eposta { get; set; }
        public string Domain_Adi { get; set; }
        public int Domain_Sure { get; set; }
        public string Firma_Logo { get; set; }
        public string Aciklama { get; set; }
        public string Uzanti_Adi { get; set; }
        public string Urun_Adi { get; set; }

        public Uzantilar uzanti { get; set; }

    }
}
