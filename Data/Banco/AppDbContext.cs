

using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Banco
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt) 
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<Produto>().HasOne(p => p.fornecedor);
            modelBuilder.Entity<Fornecedor>().HasKey(p => p.Id);
        }

    }

}
