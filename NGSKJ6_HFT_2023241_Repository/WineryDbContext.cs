using Microsoft.EntityFrameworkCore;
using NGSKJ6_HFT_2023241_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Repository
{
    public class WineryDbContext :DbContext
    {
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Winery> Wineries { get; set; }
        public DbSet<Barrell> Barrels { get; set; }

        public WineryDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseInMemoryDatabase("Wineries");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wine>(wine => wine
            .HasOne(w => w.Winery)
            .WithMany(winery => winery.Wines)
            .HasForeignKey(w => w.WineryId)
            .OnDelete(DeleteBehavior.Cascade));

            modelBuilder.Entity<Barrell>(barrel => barrel
            .HasOne(b => b.Wine)
            .WithMany(w => w.Barells)
            .HasForeignKey(b => b.WineId)
            .OnDelete(DeleteBehavior.Cascade));
            
            
            
            
            
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
