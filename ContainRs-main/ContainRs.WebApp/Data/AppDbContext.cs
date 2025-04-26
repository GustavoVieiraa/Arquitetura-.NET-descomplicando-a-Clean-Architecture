using ContainRs.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContainRs.WebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cliente>()
        .HasKey(c => c.Id);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome).IsRequired();
        modelBuilder.Entity<Cliente>()
            .Property(c => c.Email).IsRequired();
        modelBuilder.Entity<Cliente>()
            .Property(c => c.CPF).IsRequired();
    }
}
