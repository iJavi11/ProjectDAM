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
    public class EstadosPedidoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstadosPedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EstadosPedido
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoPedido>>> GetEstadoPedido()
        {
            return await _context.EstadoPedido.ToListAsync();
        }

        // GET: api/EstadosPedido/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoPedido>> GetEstadoPedido(int id)
        {
            var estadoPedido = await _context.EstadoPedido.FindAsync(id);

            if (estadoPedido == null)
            {
                return NotFound();
            }

            return estadoPedido;
        }

        // PUT: api/EstadosPedido/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoPedido(int id, EstadoPedido estadoPedido)
        {
            if (id != estadoPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadoPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoPedidoExists(id))
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

        // POST: api/EstadosPedido
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoPedido>> PostEstadoPedido(EstadoPedido estadoPedido)
        {
            _context.EstadoPedido.Add(estadoPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoPedido", new { id = estadoPedido.Id }, estadoPedido);
        }

        // DELETE: api/EstadosPedido/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoPedido(int id)
        {
            var estadoPedido = await _context.EstadoPedido.FindAsync(id);
            if (estadoPedido == null)
            {
                return NotFound();
            }

            _context.EstadoPedido.Remove(estadoPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoPedidoExists(int id)
        {
            return _context.EstadoPedido.Any(e => e.Id == id);
        }
    }
}
