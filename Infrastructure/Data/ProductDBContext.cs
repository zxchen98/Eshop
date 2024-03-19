using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Review> PaginatedResultSet { get; set; }
        public DbSet<Review> ShoppingCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>()
                .HasKey(op => op.Id);

            modelBuilder.Entity<ProductOrder>()
                .HasOne(op => op.Order)
                .WithMany(o => o.ProductOrders)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<ProductOrder>()
                .HasOne(op => op.Product)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(op => op.ProductId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews) 
                .HasForeignKey(r => r.ProductId);
        }

    }
}
