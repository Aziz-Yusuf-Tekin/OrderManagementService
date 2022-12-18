using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-65LNMFM\\SQLEXPRESS01; database=OrderManagementServiceDb; integrated security=true; TrustServerCertificate=True");
        }

        public DbSet<Company> Companys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCustomer> ProductsCustomers { get; set; }
        public DbSet<ProductCompany> ProductsCompanys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCustomer>().HasKey(x => new { x.ProductId, x.CustomerId });
            modelBuilder.Entity<ProductCompany>().HasKey(x => new { x.ProductId, x.CompanyId });
            modelBuilder.Entity<OrderProduct>().HasKey(x => new { x.OrderId, x.ProductId });
        }
    }
}
