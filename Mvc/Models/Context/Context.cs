using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = Mvc.Models.Concrete.Type;

namespace Mvc.Models.Context
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=10.108.206.9; Database=OrderTrackingCore; integrated security=false; User Id=agv; password=123456");
            optionsBuilder.UseSqlServer("server=10.3.78.84; Database=OrderTrackingCore; integrated security=false; User Id=sa; password=wsx2020.");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WorkArea>()
            .HasKey(a => new { a.AppUserId, a.SubLineId });
            modelBuilder.Entity<WarehouseUser>()
            .HasKey(a => new { a.AppUserId, a.WarehouseLocationId });
            modelBuilder.Entity<Order>().HasOne(c => c.AppUser).WithMany(c => c.AppUsers).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>().HasOne(c => c.Operation).WithMany(c => c.Operations).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<OrderLog>().HasOne(c => c.AppUserLog).WithMany(c => c.AppUserLogs).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<OrderLog>().HasOne(c => c.OperationLog).WithMany(c => c.OperationLogs).OnDelete(DeleteBehavior.Cascade);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
        public DbSet<AssemblyLine> AssemblyLines { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLog> OrderLogs { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<SubLine> SubLines { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<WarehouseLocation> WarehouseLocations { get; set; }
        public DbSet<WarehouseUser> WarehouseUsers { get; set; }
        public DbSet<WorkArea> WorkAreas { get; set; }
    }
}
