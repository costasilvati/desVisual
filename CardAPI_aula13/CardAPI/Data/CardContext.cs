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

        public DbSet<Card> Cards { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}