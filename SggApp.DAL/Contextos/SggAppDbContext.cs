using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Entidades;

namespace SggApp.DAL.Contextos
{
    public class SggAppDbContext : DbContext
    {
        public SggAppDbContext(DbContextOptions<SggAppDbContext> options)
            : base(options) { }

        // DbSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación Usuario -> Gasto
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Gastos)
                .WithOne(g => g.Usuario)
                .HasForeignKey(g => g.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Usuario -> Presupuesto
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Presupuestos)
                .WithOne(p => p.Usuario)
                .HasForeignKey(p => p.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Categoria -> Gasto
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Gastos)
                .WithOne(g => g.Categoria)
                .HasForeignKey(g => g.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Categoria -> Presupuesto
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Presupuestos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Moneda -> Gasto
            modelBuilder.Entity<Moneda>()
                .HasMany(m => m.Gastos)
                .WithOne(g => g.Moneda)
                .HasForeignKey(g => g.MonedaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Moneda -> Presupuesto
            modelBuilder.Entity<Moneda>()
                .HasMany(m => m.Presupuestos)
                .WithOne(p => p.Moneda)
                .HasForeignKey(p => p.MonedaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Índices únicos
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Categoria>()
                .HasIndex(c => c.Nombre)
                .IsUnique();

            modelBuilder.Entity<Moneda>()
                .HasIndex(m => m.Codigo)
                .IsUnique();
        }
    }
}
