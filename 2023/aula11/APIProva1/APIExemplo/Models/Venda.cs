using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public double Imposto { get; set; }

        // Relacionamento com a classe Produto
        public virtual ICollection<Produto> Produtos { get; set; }
    }

}
