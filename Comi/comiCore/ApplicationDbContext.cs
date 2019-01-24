using ComiCore.Model;
using ComiCore.ModelConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ComiCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
                                            ApplicationUserRole, IdentityUserLogin<string>,
                                            IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public void Rollback()
        {
            ChangeTracker.Entries().ToList().ForEach(x =>
            {
                x.State = EntityState.Detached;
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<FlashSale> FlashSales { get; set; }
        public DbSet<FlashSaleProduct> FlashSaleProducts { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ReceiveProduct> ReceiveProducts { get; set; }
        public DbSet<SaleOrder> SaleOrders { get; set; }
        public DbSet<SaleOrderDetail> SaleOrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<StateOrProvince> StateOrProvinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Contract>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<FlashSale>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<FlashSaleProduct>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Package>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Payment>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Vendor>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Warehouse>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<PersonInfo>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<ProductDetail>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<ReceiveProduct>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<SaleOrder>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<SaleOrderDetail>().HasQueryFilter(p => !p.Deleted);
            modelBuilder.Entity<Shipper>().HasQueryFilter(p => !p.Deleted);           

            modelBuilder.Entity<Country>().Property(c => c.Id).ValueGeneratedNever();
            modelBuilder.Entity<StateOrProvince>().Property(s => s.Id).ValueGeneratedNever();
            modelBuilder.Entity<District>().Property(d => d.Id).ValueGeneratedNever();

            modelBuilder.ApplyConfiguration(new SaleOrderConfig());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleConfig());

            modelBuilder.Seed();
        }
    }
}
