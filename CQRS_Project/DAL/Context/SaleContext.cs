using CQRS_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace CQRS_Project.DAL.Context
{
    public class SaleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-JNJNVEQ\\MERTSQL;initial catalog=SaleDb;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
