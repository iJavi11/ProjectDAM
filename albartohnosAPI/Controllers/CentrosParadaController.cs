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
    public class CentrosParadaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CentrosParadaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CentrosParada
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CentroParada>>> GetCentroParada()
        {
            return await _context.CentroParada.ToListAsync();
        }

        // GET: api/CentrosParada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroParada>> GetCentroParada(string id)
        {
            var centroParada = await _context.CentroParada.FindAsync(id);

            if (centroParada == null)
            {
                return NotFound();
            }

            return centroParada;
        }

        // PUT: api/CentrosParada/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCentroParada(string id, CentroParada centroParada)
        {
            if (id != centroParada.Id)
            {
                return BadRequest();
            }

            _context.Entry(centroParada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroParadaExists(id))
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

        // POST: api/CentrosParada
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CentroParada>> PostCentroParada(CentroParada centroParada)
        {
            _context.CentroParada.Add(centroParada);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CentroParadaExists(centroParada.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCentroParada", new { id = centroParada.Id }, centroParada);
        }

        // DELETE: api/CentrosParada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCentroParada(string id)
        {
            var centroParada = await _context.CentroParada.FindAsync(id);
            if (centroParada == null)
            {
                return NotFound();
            }

            _context.CentroParada.Remove(centroParada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CentroParadaExists(string id)
        {
            return _context.CentroParada.Any(e => e.Id == id);
        }
    }
}
