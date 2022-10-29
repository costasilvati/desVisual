using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CardAPI.Data;
using CardAPI.Data.Dtos;
using CardAPI.Data.Dtos.Banco;
using CardAPI.Data.Dtos.Cliente;
using CardAPI.Model;
using CartoesAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancoController : ControllerBase
    {
        private CardContext _contextBanco;
        private IMapper _mapperBanco;

        public BancoController(CardContext context, IMapper mapper)
        {
            _contextBanco = context;
            _mapperBanco = mapper;
        }

        [HttpPost]
        public IActionResult AddCliente([FromBody] CreateBancoDto bancoDto)
        {
            Banco banco = _mapperBanco.Map<Banco>(bancoDto);
            _contextBanco.Bancos.Add(banco);
            _contextBanco.SaveChanges();
            return CreatedAtAction(nameof(GetClienteById), new {Id =banco.Id}, banco);
        }

        [HttpGet]
        public IEnumerable<Banco> GetClientes()
        {
            return _contextBanco.Bancos;
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            Banco banco = _contextBanco.Bancos.FirstOrDefault(banco => banco.Id == id);

            if (banco != null)
            {
                ReadBancoDto bancoDto = _mapperBanco.Map<ReadBancoDto>(banco);
                return Ok(bancoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCliente(int id, [FromBody] UpdateBancoDto bancoDto)
        {
            Banco banco = _contextBanco.Bancos.FirstOrDefault(banco => banco.Id == id);
            if (banco == null)
            {
                return NotFound();
            }
            _mapperBanco.Map(bancoDto, banco);
            _contextBanco.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            Banco banco = _contextBanco.Bancos.FirstOrDefault(banco => banco.Id == id);
            if(banco == null)
            {
                return NotFound();
            }
            _contextBanco.Remove(banco);
            _contextBanco.SaveChanges();
            return NoContent();
        }

    }
}
