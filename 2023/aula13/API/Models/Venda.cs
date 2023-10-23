using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIExemplo.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        //Data agora default
        public DateTime DataVenda { get; set; }
        public double Total { get; set; }
        [JsonIgnore]
        public ICollection<VendaProduto> VendaProdutos { get; set; }
    }
}
