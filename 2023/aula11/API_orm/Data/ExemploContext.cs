using APIExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Data
{
    public class ExemploContext: DbContext
    {
        //Construtor
        public ExemploContext(
            DbContextOptions<ExemploContext> options) : base(options) { }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defina o relacionamento entre Produto e Venda
            modelBuilder.Entity<Venda>()
                .HasMany(p => p.Produtos)
                .WithMany(v => v.Vendas)
                .UsingEntity(j => j.ToTable("VendaProdutos"));
        }
    }
}
