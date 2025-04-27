using ContainRs.Application.Repositories;
using ContainRs.Domain.Models;
using ContainRs.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace ContainRs.WebApp.Data;

public class AppDbContext : DbContext, IClienteRepository
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    public async Task<Cliente> AddASync(Cliente cliente)
    {
        await Clientes.AddAsync(cliente);
        await SaveChangesAsync();
        return cliente;
    }

    public async Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente, bool>>? filtro = null)
    {
        IQueryable<Cliente> queryClientes = this.Clientes;
        if (filtro != null)
        {
            queryClientes = queryClientes.Where(filtro);
        }
        return await queryClientes
            .AsNoTracking()
            .ToListAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cliente>()
        .HasKey(c => c.Id);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome).IsRequired();
        modelBuilder.Entity<Cliente>()
            .OwnsOne(c => c.Email, cfg =>
            {
                cfg.Property(e => e.Value)
                .HasColumnName("Email")
                .IsRequired();
            });
        modelBuilder.Entity<Cliente>()
            .Property(c => c.Estado)
            .HasConversion<string>();
        modelBuilder.Entity<Cliente>()
            .Property(c => c.CPF).IsRequired();
    }
}
