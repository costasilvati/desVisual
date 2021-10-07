using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Model
{
    public class Card
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public DateTime ExprirationDate { get; set; }
        public bool Blocked { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
    }
}
