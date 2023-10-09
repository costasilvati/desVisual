using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public double Valor { get; set; }

        [Required]
        public int Quantidade { get; set; }

        // Relacionamento com a classe Venda
        public virtual ICollection<Venda> Vendas { get; set; }
    }

}
