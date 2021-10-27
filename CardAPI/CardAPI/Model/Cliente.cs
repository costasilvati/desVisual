using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Model
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string Cpf { get; set; }
        public Card Card { get; set; }

    }
}
