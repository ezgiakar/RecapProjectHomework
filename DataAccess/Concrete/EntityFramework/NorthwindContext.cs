using Entity.Concrete;
using Entity.DTOes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CarDatabase;
                                        Trusted_Connection=true");
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        //public DbSet<CarDetailDto> CarDetailDtoes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<CarDetailDto>().ToTable("Cars");
        //    modelBuilder.Entity<CarDetailDto>().ToTable("Brands");
        //    modelBuilder.Entity<CarDetailDto>().ToTable("Colors");
        //    modelBuilder.Entity<CarDetailDto>().Property(p => p.CarName).HasColumnName("CarDescription");
        //    modelBuilder.Entity<CarDetailDto>().Property(p => p.BrandName).HasColumnName("CarBrandName");
        //    modelBuilder.Entity<CarDetailDto>().Property(p => p.ColorName).HasColumnName("ColorName");
        //    modelBuilder.Entity<CarDetailDto>().Property(p => p.DailyPrice).HasColumnName("CarDailyPrice");
        //}
    }
}
