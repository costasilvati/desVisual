using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Model
{
    public class Administra
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Banco Banco { get; set; }
        public int BancoId { get; set; }
        public int ClienteId { get; set; }
    }
}
