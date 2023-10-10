using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public ICollection<Venda> Vendas { get; set; }
    }
}
