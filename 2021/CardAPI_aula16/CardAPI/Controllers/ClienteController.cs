using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CardAPI.Data;
using CardAPI.Data.Dtos;
using CardAPI.Data.Dtos.Cliente;
using CardAPI.Model;
using CartoesAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private CardContext _contextCli;
        private IMapper _mapperCli;

        public ClienteController(CardContext context, IMapper mapper)
        {
            _contextCli = context;
            _mapperCli = mapper;
        }

        [HttpPost]
        public IActionResult AddCliente([FromBody] CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapperCli.Map<Cliente>(clienteDto);
            _contextCli.Clientes.Add(cliente);
            _contextCli.SaveChanges();
            return CreatedAtAction(nameof(GetClienteById), new {Id =cliente.Id}, cliente);
        }

        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _contextCli.Clientes;
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            Cliente cliente = _contextCli.Clientes.FirstOrDefault(cliente => cliente.Id == id);

            if (cliente != null)
            {
                ReadClienteDto clienteDto = _mapperCli.Map<ReadClienteDto>(cliente);
                return Ok(clienteDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            Cliente cliente = _contextCli.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _mapperCli.Map(clienteDto, cliente);
            _contextCli.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            Cliente cliente = _contextCli.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if(cliente == null)
            {
                return NotFound();
            }
            _contextCli.Remove(cliente);
            _contextCli.SaveChanges();
            return NoContent();
        }

    }
}
