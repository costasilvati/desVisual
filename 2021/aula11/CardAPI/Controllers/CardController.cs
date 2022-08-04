using System;
using System.Collections.Generic;
using System.Linq;
using CardAPI.Data;
using CardAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCard([FromBody] Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardById), new {Id =card.Id}, card);
        }

        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards;
        }

        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            Card card = _context.Cards.FirstOrDefault(card => card.Id == id);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound();
        }
    }
}
