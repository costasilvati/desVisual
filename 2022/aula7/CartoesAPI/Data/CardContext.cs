using System;
using CartoesAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CardAPI.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> opt) : base(opt)
        {
        }

        public DbSet<Card> Cards { get; set; }
    }
}
