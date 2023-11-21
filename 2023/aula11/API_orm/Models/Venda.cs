﻿using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        //Data agora default
        public DateTime DataVenda { get; set; }
        public double Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}