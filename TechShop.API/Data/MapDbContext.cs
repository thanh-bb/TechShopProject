//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace TechShop.API.Data;

//public partial class MapDbContext : DbContext
//{
//    //public MapDbContext()
//    //{
//    //}

//    //public MapDbContext(DbContextOptions<MapDbContext> options)
//    //    : base(options)
//    //{
//    //}

//    //public virtual DbSet<Dulieumau> Dulieumaus { get; set; }

//    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    //    => optionsBuilder.UseSqlServer("Name=ConnectionStrings:MapConnection", x => x.UseNetTopologySuite());

//    //protected override void OnModelCreating(ModelBuilder modelBuilder)
//    //{
//    //    modelBuilder.Entity<Dulieumau>(entity =>
//    //    {
//    //        entity
//    //            .HasNoKey()
//    //            .ToTable("DULIEUMAU");

//    //        entity.Property(e => e.Id)
//    //            .ValueGeneratedOnAdd()
//    //            .HasColumnName("id");
//    //        entity.Property(e => e.Name).HasMaxLength(50);
//    //        entity.Property(e => e.TheGeom)
//    //            .HasColumnType("geometry")
//    //            .HasColumnName("The_geom");
//    //    });

//    //    OnModelCreatingPartial(modelBuilder);
//    //}

//    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
