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
    public class EstadosRutaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstadosRutaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EstadosRuta
        [HttpGet]
        public async Task<List<EstadoRuta>> GetEstadosRuta()
        {
            return await Negocio.GetRouteStates();
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------------------
         * NO SE REQUIERE DE ESTOS MÉTODOS YA QUE EN PRINCIPIO NO SE MANEJARÁN LOS ESTADOS DE LAS RUTAS.
         * SE COMENTA YA QUE EN UN FUTURO SE PODRÍAN REQUERIR.
         */

        /* ------------------------------------------------------------------------------------------------------------------------------------------------

        // GET: api/EstadosRuta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoRuta>> GetEstadoRuta(int id)
        {
            var estadoRuta = await _context.EstadoRuta.FindAsync(id);

            if (estadoRuta == null)
            {
                return NotFound();
            }

            return estadoRuta;
        }

        // PUT: api/EstadosRuta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoRuta(int id, EstadoRuta estadoRuta)
        {
            if (id != estadoRuta.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadoRuta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoRutaExists(id))
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

        // POST: api/EstadosRuta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoRuta>> PostEstadoRuta(EstadoRuta estadoRuta)
        {
            _context.EstadoRuta.Add(estadoRuta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoRuta", new { id = estadoRuta.Id }, estadoRuta);
        }

        // DELETE: api/EstadosRuta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoRuta(int id)
        {
            var estadoRuta = await _context.EstadoRuta.FindAsync(id);
            if (estadoRuta == null)
            {
                return NotFound();
            }

            _context.EstadoRuta.Remove(estadoRuta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoRutaExists(int id)
        {
            return _context.EstadoRuta.Any(e => e.Id == id);
        }

        ------------------------------------------------------------------------------------------------------------------------------------------------ */
    }
}
