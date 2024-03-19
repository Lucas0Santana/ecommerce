using System.Collections.Immutable;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Credenciais>? Credenciais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(builder =>
            {
                builder.CommandTimeout(300); // Definindo o tempo limite de comando para 300 segundos
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            var credenciais = modelBuilder.Entity<Credenciais>();
            credenciais.ToTable("Credenciais");
            credenciais.HasKey(c => c.Id);
            credenciais.Property(c => c.Id).ValueGeneratedOnAdd().HasColumnName("id");
            credenciais.Property(c => c.Nome).IsRequired().HasMaxLength(50).HasColumnName("nome");
            credenciais.Property(c => c.Email).IsRequired().HasMaxLength(50).HasColumnName("email");
            credenciais.Property(c => c.Senha).IsRequired().HasMaxLength(100).HasColumnName("senha");
            credenciais.Property(c => c.Status).IsRequired().HasColumnName("status");
        }
    }
}