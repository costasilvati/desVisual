using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Model
{
    public class Card
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Number need be 16 characters")]
        [StringLength(16, ErrorMessage ="Number can't be lower of 16 characters")]
        public string Number { get; set; }
        [Required(ErrorMessage ="Field ExpirationDate is required")]
        public DateTime ExprirationDate { get; set; }
        //[Required]
        //[Range(1,10, ErrorMessage="O valor deve ser entre 1 e 10")]
        public bool Blocked { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
    }
}
