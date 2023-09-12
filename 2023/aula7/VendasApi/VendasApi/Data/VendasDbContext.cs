using Microsoft.EntityFrameworkCore;
using VendasApi.Models;

namespace VendasApi.Data
{
    public class VendasDbContext : DbContext
    {
        public VendasDbContext(DbContextOptions<VendasDbContext> options): base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
