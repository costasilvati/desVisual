using System;
using System.Collections.Generic;
using CartoesAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CartoesAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CardController : ControllerBase
    {
        private static List<Card> cards = new List<Card>();

        [HttpPost]
        public void AddCard([FromBody] Card card)
        {
            cards.Add(card);
            Console.WriteLine(card.CardNumber);
        }

        [HttpGet]
        public IEnumerable<Card> Get()
        {
            return cards;
        }

    }
}
