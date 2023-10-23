using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIExemplo.Data;
using APIExemplo.Models;

namespace APIExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly ExemploContext _context;

        public VendasController(ExemploContext context)
        {
            _context = context;
        }

        // GET: api/Vendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venda>>> GetVendas()
        {
          if (_context.Vendas == null)
          {
              return NotFound();
          }
            return await _context.Vendas.ToListAsync();
        }

        // GET: api/Vendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venda>> GetVenda(int id)
        {
          if (_context.Vendas == null)
          {
              return NotFound();
          }
            var venda = await _context.Vendas.FindAsync(id);

            if (venda == null)
            {
                return NotFound();
            }

            return venda;
        }

        // PUT: api/Vendas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenda(int id, Venda venda)
        {
            if (id != venda.Id)
            {
                return BadRequest();
            }

            _context.Entry(venda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpGet("venda/{vendaId}/produtos")]
        public IActionResult GetProdutosDaVenda(int vendaId)
        {
            var venda = _context.Vendas
                .Include(v => v.VendaProdutos)
                .ThenInclude(vp => vp.Produto)
                .SingleOrDefault(v => v.Id == vendaId);

            if (venda == null)
            {
                return NotFound("Venda não encontrada.");
            }

            var produtosDaVenda = venda.VendaProdutos.Select(vp => vp.Produto).ToList();

            return Ok(produtosDaVenda);
        }

        [HttpGet("venda/{vendaId}/detalhes")]
        public IActionResult GetDetalhesDaVenda(int vendaId)
        {
            var venda = _context.Vendas
                .Include(v => v.VendaProdutos)
                .ThenInclude(vp => vp.Produto)
                .SingleOrDefault(v => v.Id == vendaId);

            if (venda == null)
            {
                return NotFound("Venda não encontrada.");
            }

            var vendaDetalhada = new VendaDetalhadaResponse
            {
                VendaId = venda.Id,
                DataVenda = venda.DataVenda,
                Total = venda.Total,
                Produtos = venda.VendaProdutos.Select(vp => vp.Produto).ToList()
            };

            return Ok(vendaDetalhada);
        }


        [HttpPost("addProduto")]
        public async Task<IActionResult> PostVenda(VendaInputModel model)
        {
            var venda = new Venda
            {
                DataVenda = model.Data,
                Total = model.Total,
                VendaProdutos = model.ProdutosIds.Select(productId => new VendaProduto
                {
                    ProdutoId = productId
                }).ToList()
            };

            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenda", new { id = venda.Id }, venda);
        }


        // POST: api/Vendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Venda>> PostVenda(Venda venda)
        {
          if (_context.Vendas == null)
          {
              return Problem("Entity set 'ExemploContext.Vendas'  is null.");
          }
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenda", new { id = venda.Id }, venda);
        }

        // DELETE: api/Vendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenda(int id)
        {
            if (_context.Vendas == null)
            {
                return NotFound();
            }
            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }

            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendaExists(int id)
        {
            return (_context.Vendas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
