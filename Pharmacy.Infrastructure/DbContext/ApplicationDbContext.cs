using MedicineShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Pharmacy.Infrastructure.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Inventory> inventory { get; set; }
        public virtual DbSet<Medicine> medicine { get; set; }
        public virtual DbSet<Permission> permissions { get; set; }
        public virtual DbSet<Role> role { get; set; }
        public virtual DbSet<Sale> sale { get; set; }
        public virtual DbSet<Shop> shop { get; set; }
        public virtual DbSet<Stock> stock { get; set; }
        public virtual DbSet<Supplier> supplier { get; set; }
        public virtual DbSet<User> user { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //.HasMany(navigationExpression e => e.CategoryProduct)
            //.WithMany(NavigationExtensions e => e.Posts);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration Configuration = builder.Build();

            

            optionsBuilder.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
