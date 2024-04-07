using System.Collections.Immutable;
using ecommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Administrador>? Administrador { get; set; }
        public DbSet<Carrinho>? Carrinho { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Credenciais>? Credenciais { get; set; }
        public DbSet<Endereco>? Endereco { get; set; }
        public DbSet<Estorno>? Estorno { get; set; }
        public DbSet<Item>? Item { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<SolicitacaoDeEstorno>? SolicitacaoDeEstorno { get; set; }
        public DbSet<Transacao>? Transacao { get; set; }
        public DbSet<Varejista>? Varejista { get; set; }


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

            var administrador = modelBuilder.Entity<Administrador>();
            administrador.ToTable("Administrador");
            administrador.HasKey(a => a.Id);
            administrador.Property(a => a.Id).ValueGeneratedOnAdd().HasColumnName("id");
            administrador.Property(a => a.IdCredenciais).IsRequired().HasColumnName("idCredenciais");

            var carrinho = modelBuilder.Entity<Carrinho>();
            carrinho.ToTable("Carrinho");
            carrinho.HasKey(c => c.Id);
            carrinho.Property(c => c.Id).ValueGeneratedOnAdd().HasColumnName("id");
            // carrinho.Property(c => c.IdCliente).IsRequired().HasColumnName("idCliente");

            var cliente = modelBuilder.Entity<Cliente>();
            cliente.ToTable("Cliente");
            cliente.HasKey(c => c.CPF);
            cliente.Property(c => c.CPF).HasColumnName("cpf");
            cliente.Property(c => c.IdCredenciais).IsRequired().HasColumnName("idCredenciais");

            var credenciais = modelBuilder.Entity<Credenciais>();
            credenciais.ToTable("Credenciais");
            credenciais.HasKey(c => c.Id);
            credenciais.Property(c => c.Id).ValueGeneratedOnAdd().HasColumnName("id");
            credenciais.Property(c => c.Nome).IsRequired().HasMaxLength(50).HasColumnName("nome");
            credenciais.Property(c => c.Email).IsRequired().HasMaxLength(50).HasColumnName("email");
            credenciais.Property(c => c.Senha).IsRequired().HasMaxLength(100).HasColumnName("senha");
            credenciais.Property(c => c.Status).IsRequired().HasColumnName("status");
                        
            var endereco = modelBuilder.Entity<Endereco>();
            endereco.ToTable("Endereco");
            endereco.HasKey(e => e.Id);
            endereco.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
            endereco.Property(e => e.CEP).IsRequired().HasMaxLength(8).HasColumnName("cep");
            endereco.Property(e => e.Numero).IsRequired().HasColumnName("numero");
            endereco.Property(e => e.Complemento).HasMaxLength(100).HasColumnName("complemento");
            endereco.Property(e => e.Bairro).IsRequired().HasMaxLength(100).HasColumnName("bairro");
            endereco.Property(e => e.Cidade).IsRequired().HasMaxLength(100).HasColumnName("cidade");
            endereco.Property(e => e.Estado).IsRequired().HasMaxLength(2).HasColumnName("estado");

            var estorno = modelBuilder.Entity<Estorno>();
            estorno.ToTable("Estorno");
            estorno.HasKey(e => e.Id);
            estorno.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
            estorno.Property(e => e.Valor).IsRequired().HasColumnName("valor");
            estorno.Property(e => e.CPFDestinatario).IsRequired().HasColumnName("cpfDestinatario");

            var item = modelBuilder.Entity<Item>();
            item.ToTable("Item");
            item.HasKey(i => i.Id);
            item.Property(i => i.Id).ValueGeneratedOnAdd().HasColumnName("id");
            item.Property(i => i.Qtde).IsRequired().HasColumnName("qtde");
            item.Property(i => i.IdProduto).IsRequired().HasColumnName("idProduto");
            
            var pedido = modelBuilder.Entity<Pedido>();
            pedido.ToTable("Pedido");
            pedido.HasKey(p => p.Id);
            pedido.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
            pedido.Property(p => p.Valor).IsRequired().HasColumnName("valor");
            pedido.Property(p => p.Data).IsRequired().HasColumnName("data");
            pedido.Property(p => p.Frete).IsRequired().HasColumnName("frete");
            pedido.Property(p => p.Status).IsRequired().HasColumnName("status");
            pedido.Property(p => p.CNPJ).IsRequired().HasColumnName("cnpj");
            pedido.Property(p => p.CPF).IsRequired().HasColumnName("cpf");
            pedido.Property(p => p.IdTransacao).IsRequired().HasColumnName("idTransacao");
            
            var produto = modelBuilder.Entity<Produto>();
            produto.ToTable("Produto");
            produto.HasKey(p => p.Id);
            produto.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
            produto.Property(p => p.Nome).IsRequired().HasMaxLength(100).HasColumnName("nome");
            produto.Property(p => p.Descricao).HasMaxLength(500).HasColumnName("descricao");
            produto.Property(p => p.Preco).IsRequired().HasColumnName("preco");
            produto.Property(p => p.CNPJ).IsRequired().HasColumnName("cnpj");
            produto.Property(p => p.Status).IsRequired().HasColumnName("status");

            var solicitacaoDeEstorno = modelBuilder.Entity<SolicitacaoDeEstorno>();
            solicitacaoDeEstorno.ToTable("SolicitacaoDeEstorno");
            solicitacaoDeEstorno.HasKey(s => s.Id);
            solicitacaoDeEstorno.Property(s => s.Id).ValueGeneratedOnAdd().HasColumnName("id");
            solicitacaoDeEstorno.Property(s => s.CPF).IsRequired().HasColumnName("cpf");
            solicitacaoDeEstorno.Property(s => s.IdTransacao).IsRequired().HasColumnName("idTransacao");
            solicitacaoDeEstorno.Property(s => s.IdAdministrador).IsRequired().HasColumnName("idAdministrador");
            // solicitacaoDeEstorno.Property(s => s.Valor).IsRequired().HasColumnName("valor");
            // solicitacaoDeEstorno.Property(s => s.IdEstorno).IsRequired().HasColumnName("idEstorno");

            var transacao = modelBuilder.Entity<Transacao>();
            transacao.ToTable("Transacao");
            transacao.HasKey(t => t.Id);
            transacao.Property(t => t.Id).ValueGeneratedOnAdd().HasColumnName("id");
            transacao.Property(t => t.Valor).IsRequired().HasColumnName("valor");

            var varejista = modelBuilder.Entity<Varejista>();
            varejista.ToTable("Varejista");
            varejista.HasKey(v => v.CNPJ);
            varejista.Property(v => v.CNPJ).HasColumnName("cnpj");
            varejista.Property(v => v.IdCredenciais).IsRequired().HasColumnName("idCredenciais");
            


        }
    }
}