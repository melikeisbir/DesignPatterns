using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MELI\\SQLEXPRESS;initial catalog=DesignPattern6;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
