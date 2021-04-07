using EfCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=devio04.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(p =>
            {
                p.ToTable("Pessoas");
                p.HasKey(e => e.Id);
                p.Property(e => e.Nome).IsRequired();

                p.OwnsOne(e => e.Endereco);
            });
        }
    }
}