using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=TurgayKarakoc;database=CoreBera;integrated security=true;");
        }

        public DbSet<Kullanicilar> kullanicilars { get; set; }
        public DbSet<Musteriler> musterilers { get; set; }
        public DbSet<Talepler> taleplers { get; set; }
        public DbSet<Uzantilar> uzantilars { get; set; }
    }
}
