using Microsoft.Extensions.Hosting;

namespace APIExemplo.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public ICollection<Post> Posts { get; } = new List<Post>(); // Collection navigation containing dependents
    }
}
