using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Data.Dtos.Card
{
    public class ReadCardDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Number need be 16 characters")]
        [StringLength(16, ErrorMessage = "Number can't be lower of 16 characters")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Field ExpirationDate is required")]
        public DateTime ExprirationDate { get; set; }
        public bool Blocked { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Message { get; set; }
        public Model.Cliente Cliente { get; set; }
    }
}