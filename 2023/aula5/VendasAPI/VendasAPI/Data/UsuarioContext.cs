using Microsoft.EntityFrameworkCore;
using VendasAPI.Model;

namespace VendasAPI.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> opt) : base(opt) { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }
}
