using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Facade.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MELI\\SQLEXPRESS;initial catalog=DesignPattern10;integrated security=true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
