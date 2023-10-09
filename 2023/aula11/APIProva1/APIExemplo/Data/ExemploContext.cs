using APIExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Data
{
    public class ExemploContext: DbContext
    {
        //Construtor
        public ExemploContext(
            DbContextOptions<ExemploContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defina o relacionamento entre Produto e Venda
            modelBuilder.Entity<Produto>()
                .HasMany(p => p.Vendas)
                .WithMany(v => v.Produtos)
                .UsingEntity(j => j.ToTable("VendaProdutos"));
        }
    }
}
