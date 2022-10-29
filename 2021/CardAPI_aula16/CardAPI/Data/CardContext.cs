using System;
using CardAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CartoesAPI.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Cliente>()
                .HasIndex(c => c.Cpf)
                .IsUnique(true);

            builder.Entity<Card>()
                .HasOne(card => card.Cliente)
                .WithMany(cliente => cliente.Cards)
                .HasForeignKey(card => card.ClienteId);

            builder.Entity<Administra>()
                .HasOne(adm => adm.Banco)
                .WithMany(banco => banco.Administrados)
                .HasForeignKey(adm => adm.BancoId);

            builder.Entity<Administra>()
                .HasOne(adm => adm.Cliente)
                .WithMany(cliente => cliente.AdminstradoPor)
                .HasForeignKey(adm => adm.ClienteId);

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Administra> Administras { get; set; }
    }
}