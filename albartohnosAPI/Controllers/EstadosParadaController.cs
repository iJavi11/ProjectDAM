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
    public class EstadosParadaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstadosParadaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EstadosParada
        [HttpGet]
        public async Task<List<EstadoParada>> GetEstadoParada()
        {
            return await Negocio.GetStopStates();
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------------------
         * NO SE REQUIERE DE ESTOS MÉTODOS YA QUE EN PRINCIPIO NO SE MANEJARÁN LOS ESTADOS DE LAS PARADAS.
         * SE COMENTA YA QUE EN UN FUTURO SE PODRÍAN REQUERIR.
         */

        /* ------------------------------------------------------------------------------------------------------------------------------------------------

        // GET: api/EstadosParada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoParada>> GetEstadoParada(int id)
        {
            var estadoParada = await _context.EstadoParada.FindAsync(id);

            if (estadoParada == null)
            {
                return NotFound();
            }

            return estadoParada;
        }

        // PUT: api/EstadosParada/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoParada(int id, EstadoParada estadoParada)
        {
            if (id != estadoParada.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadoParada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoParadaExists(id))
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

        // POST: api/EstadosParada
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoParada>> PostEstadoParada(EstadoParada estadoParada)
        {
            _context.EstadoParada.Add(estadoParada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoParada", new { id = estadoParada.Id }, estadoParada);
        }

        // DELETE: api/EstadosParada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoParada(int id)
        {
            var estadoParada = await _context.EstadoParada.FindAsync(id);
            if (estadoParada == null)
            {
                return NotFound();
            }

            _context.EstadoParada.Remove(estadoParada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoParadaExists(int id)
        {
            return _context.EstadoParada.Any(e => e.Id == id);
        }

        ------------------------------------------------------------------------------------------------------------------------------------------------ */
    }
}
