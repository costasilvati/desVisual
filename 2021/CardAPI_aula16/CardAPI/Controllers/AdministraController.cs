using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CardAPI.Data;
using CardAPI.Data.Dtos;
using CardAPI.Data.Dtos.Administra;
using CardAPI.Model;
using CartoesAPI.Data;
using Microsoft.AspNetCore.Mvc;


namespace CardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdministraController : ControllerBase
    {
        private CardContext _context;
        private IMapper _mapper;

        public AdministraController(CardContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAdministra([FromBody] CreateAdministraDto adminDto)
        {
            Administra admin = _mapper.Map<Administra>(adminDto);
            _context.Administras.Add(admin);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAdministradById), new { Id = admin.Id }, admin);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdministradById(int id)
        {
            Administra adm = _context.Administras.FirstOrDefault(admin => admin.Id == id);

            if (adm != null)
            {
                ReadAdministraDto admDto = _mapper.Map<ReadAdministraDto>(adm);
                return Ok(admDto);
            }
            return NotFound();
        }
    }
}
