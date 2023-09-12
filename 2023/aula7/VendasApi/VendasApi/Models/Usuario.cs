using System.ComponentModel.DataAnnotations;

namespace VendasApi.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nome { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório")]
        public string? Email { get; set; }
        public string? Fone { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }
    }
}
