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
    public class TiposCentroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiposCentroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TiposCentro
        [HttpGet]
        public async Task<List<TipoCentro>> GetTiposCentro()
        {
            return await Negocio.GetStopCenterTypes();
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------------------
         * NO SE REQUIERE DE ESTOS MÉTODOS YA QUE EN PRINCIPIO NO SE MANEJARÁN LOS TIPOS DE LOS CENTROS.
         * SE COMENTA YA QUE EN UN FUTURO SE PODRÍAN REQUERIR.
         */

        /* ------------------------------------------------------------------------------------------------------------------------------------------------

        // GET: api/TiposCentro/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoCentro>> GetTipoCentro(int id)
        {
            var tipoCentro = await _context.TipoCentro.FindAsync(id);

            if (tipoCentro == null)
            {
                return NotFound();
            }

            return tipoCentro;
        }

        // PUT: api/TiposCentro/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoCentro(int id, TipoCentro tipoCentro)
        {
            if (id != tipoCentro.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoCentro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoCentroExists(id))
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

        // POST: api/TiposCentro
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoCentro>> PostTipoCentro(TipoCentro tipoCentro)
        {
            _context.TipoCentro.Add(tipoCentro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoCentro", new { id = tipoCentro.Id }, tipoCentro);
        }

        // DELETE: api/TiposCentro/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoCentro(int id)
        {
            var tipoCentro = await _context.TipoCentro.FindAsync(id);
            if (tipoCentro == null)
            {
                return NotFound();
            }

            _context.TipoCentro.Remove(tipoCentro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoCentroExists(int id)
        {
            return _context.TipoCentro.Any(e => e.Id == id);
        }

        ------------------------------------------------------------------------------------------------------------------------------------------------ */
    }
}
