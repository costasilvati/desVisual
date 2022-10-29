using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        // Unique em CardContext linha 17 a 20
        public string Cpf { get; set; }
        [JsonIgnore]
        public virtual List<Card> Cards { get; set; }
        public virtual List<Administra> AdminstradoPor { get; set; }

    }
}
