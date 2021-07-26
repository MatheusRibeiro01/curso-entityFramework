using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapeamento de chave primaria composta para a tabela de join PromocaoProduto
            modelBuilder.Entity<PromocaoProduto>().
                HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
            base.OnModelCreating(modelBuilder);

            //Setando o nome de tabela de endereços para "Enderecos" pro entity não pegar o nome da propriedade no singular
            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");

            //Definindo propriedade shadow property
            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");

            //Definindo shadow property como chave primaria da tabela endereco
            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }

        internal object GetInfraestructure<T>()
        {
            throw new NotImplementedException();
        }
    }

   
}