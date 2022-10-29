using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CardAPI.Model
{
    public class Banco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        [Required]
        public string Cnpj { get; set; }
        public virtual List<Administra> Administrados { get; set; }
    }
}
