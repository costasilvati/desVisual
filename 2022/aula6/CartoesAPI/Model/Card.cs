using System;
using System.ComponentModel.DataAnnotations;

namespace CartoesAPI.Model
{
    public class Card
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public DateTime ExpiratenDate { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        public bool Blocked { get; set; }

        /*
         * {
  "Id":1,
  "CardNumber":"990909900",
  "ExpirationDate":"2022-10-01",
  "SecurityCode":"222",
  "Blocked":"True"
}
        */
        public Card()
        {
        }
    }
}
