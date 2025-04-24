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
    public class HistoricoRutasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HistoricoRutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HistoricoRutas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoricoRuta>>> GetHistoricoRuta()
        {
            return await _context.HistoricoRuta.ToListAsync();
        }

        // GET: api/HistoricoRutas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HistoricoRuta>> GetHistoricoRuta(int id)
        {
            var historicoRuta = await _context.HistoricoRuta.FindAsync(id);

            if (historicoRuta == null)
            {
                return NotFound();
            }

            return historicoRuta;
        }

        // PUT: api/HistoricoRutas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoricoRuta(int id, HistoricoRuta historicoRuta)
        {
            if (id != historicoRuta.Id)
            {
                return BadRequest();
            }

            _context.Entry(historicoRuta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoricoRutaExists(id))
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

        // POST: api/HistoricoRutas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HistoricoRuta>> PostHistoricoRuta(HistoricoRuta historicoRuta)
        {
            _context.HistoricoRuta.Add(historicoRuta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoricoRuta", new { id = historicoRuta.Id }, historicoRuta);
        }

        // DELETE: api/HistoricoRutas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoricoRuta(int id)
        {
            var historicoRuta = await _context.HistoricoRuta.FindAsync(id);
            if (historicoRuta == null)
            {
                return NotFound();
            }

            _context.HistoricoRuta.Remove(historicoRuta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HistoricoRutaExists(int id)
        {
            return _context.HistoricoRuta.Any(e => e.Id == id);
        }
    }
}
