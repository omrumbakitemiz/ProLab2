using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProLab.GUI.Data.Models;

namespace ProLab.GUI.Data.Context
{
    public class TamirhaneDBContext : DbContext
    {
        public TamirhaneDBContext() : 
            base("name=ConnStrAzure") {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Arac> Araclar { get; set; }
        public DbSet<KaportaIslemi> KaportaIslemleri { get; set; }
        public DbSet<ElektrikIslemi> ElektrikIslemleri { get; set; }
        public DbSet<MotorIslemi> MotorIslemleri { get; set; }
        public DbSet<LastikIslemi> LastikIslemleri { get; set; }
    }
}
