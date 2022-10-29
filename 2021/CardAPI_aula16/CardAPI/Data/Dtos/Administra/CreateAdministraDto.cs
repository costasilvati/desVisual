using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Data.Dtos.Administra
{
    public class CreateAdministraDto
    {
        [Key]
        public int BancoId { get; set; }
        public int ClienteId { get; set; }
    }
}
