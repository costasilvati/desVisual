using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Data.Dtos.Banco
{
    public class UpdateBancoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        [Required]
        public string Cnpj { get; set; }
    }
}