using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Data.Dtos.Cliente
{
    public class ReadClienteDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        // Unique []
        public string Cpf { get; set; }
        public object Cards { get; set; }
    }
}
