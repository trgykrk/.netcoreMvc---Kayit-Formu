using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Models
{
    public class Uzantilar
    {

         [Key]
         public int Uzanti_ID { get; set; }
         public string Uzanti_Adi { get; set; }
         public List<Musteriler> musterilers { get; set; }
    }
}
