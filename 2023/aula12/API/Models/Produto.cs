using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        [JsonIgnore]
        public List<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
