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
        public DbSet<VendaProduto> VendaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendaProduto>()
                .HasKey(vp => new { vp.VendaId, vp.ProdutoId });

            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.Venda)
                .WithMany(v => v.VendaProdutos)
                .HasForeignKey(vp => vp.VendaId);

            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.Produto)
                .WithMany(p => p.VendaProdutos)
                .HasForeignKey(vp => vp.ProdutoId);
        }
    }
    
}
