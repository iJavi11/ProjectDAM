using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using albartohnosAPI.Data;
using albartohnosAPI.Models;

namespace albartohnosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposPedidoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiposPedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TiposPedido
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPedido>>> GetTipoPedido()
        {
            return await _context.TipoPedido.ToListAsync();
        }

        // GET: api/TiposPedido/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoPedido>> GetTipoPedido(int id)
        {
            var tipoPedido = await _context.TipoPedido.FindAsync(id);

            if (tipoPedido == null)
            {
                return NotFound();
            }

            return tipoPedido;
        }

        // PUT: api/TiposPedido/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoPedido(int id, TipoPedido tipoPedido)
        {
            if (id != tipoPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPedidoExists(id))
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

        // POST: api/TiposPedido
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoPedido>> PostTipoPedido(TipoPedido tipoPedido)
        {
            _context.TipoPedido.Add(tipoPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoPedido", new { id = tipoPedido.Id }, tipoPedido);
        }

        // DELETE: api/TiposPedido/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoPedido(int id)
        {
            var tipoPedido = await _context.TipoPedido.FindAsync(id);
            if (tipoPedido == null)
            {
                return NotFound();
            }

            _context.TipoPedido.Remove(tipoPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoPedidoExists(int id)
        {
            return _context.TipoPedido.Any(e => e.Id == id);
        }
    }
}
