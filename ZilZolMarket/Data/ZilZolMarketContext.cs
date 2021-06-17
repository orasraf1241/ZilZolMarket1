using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZilZolMarket.Models;

namespace ZilZolMarket.Data
{
    public class ZilZolMarketContext : DbContext
    {
        public ZilZolMarketContext (DbContextOptions<ZilZolMarketContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>()
                 .HasKey(po => new { po.ProductId, po.OrderId });

            modelBuilder.Entity<ProductOrder>()
                .HasOne(po => po.Product)
                .WithMany(o => o.ProductsOrders)
                .HasForeignKey(po => po.ProductId);

            modelBuilder.Entity<ProductOrder>()
                .HasOne(po => po.Orders)
                .WithMany(o => o.ProductsOrders)
                .HasForeignKey(po => po.OrderId);
        }


        public DbSet<ZilZolMarket.Models.Product> Product { get; set; }

        public DbSet<ZilZolMarket.Models.Pc> Pc { get; set; }

        public DbSet<ZilZolMarket.Models.Phone> Phone { get; set; }

        public DbSet<ZilZolMarket.Models.Screen> Screen { get; set; }


        public DbSet<ZilZolMarket.Models.Orders> Orders { get; set; }

        public DbSet<ZilZolMarket.Models.User> User { get; set; }

        public DbSet<Branch> Branch { get; set; }

        public DbSet<ZilZolMarket.Models.ProductOrder> ProductOrder { get; set; }
    }
}
