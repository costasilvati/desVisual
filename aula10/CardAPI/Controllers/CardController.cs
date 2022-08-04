using System;
using System.Collections.Generic;
using System.Linq;
using CardAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private static List<Card> cards = new List<Card>();

        [HttpPost]
        public void AddCard([FromBody] Card card)
        {
            cards.Add(card);
            Console.WriteLine(card.Number);
        }

        [HttpGet]
        public IActionResult GetCards()
        {
            return Ok(cards);
        }

        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            Card card = cards.FirstOrDefault(card => card.Id == id);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound();
        }
    }
}
