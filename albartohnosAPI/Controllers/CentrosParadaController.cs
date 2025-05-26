using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using albartohnosAPI.Data;
using albartohnosAPI.Models;
using Serilog;

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
        public async Task<List<CentroParada>> GetAllCentrosParada()
        {
            return await Negocio.GetAllStopCenters();
        }

        // GET: api/CentrosParada/Almacenes
        [HttpGet("Almacenes")]
        public async Task<List<CentroParada>> GetAllAlmacenes()
        {
            return await Negocio.GetAllWarehouses();
        }

        // GET: api/CentrosParada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroParada>> GetCentroParadaById(string id)
        {
            var centroParada = await Negocio.GetStopCenterById(id);

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
                Log.Information($"Stop Center: {centroParada.Id} - {centroParada.Nombre} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.StopCenterExists(id))
                {
                    Log.Warning($"Stop Center -- {centroParada.Id} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing a stop center: {dbEx.Message}");
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
                Log.Information($"Stop Center: {centroParada.Id} - {centroParada.Nombre} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.StopCenterExists(centroParada.Id))
                {
                    Log.Warning($"Stop Center -- {centroParada.Id} - {centroParada.Nombre} -- already exits");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while editing a stop center: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetCentroParadaById", new { id = centroParada.Id }, centroParada);
        }

        // DELETE: api/CentrosParada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCentroParada(string id)
        {
            var centroParada = await Negocio.GetStopCenterById(id);
            if (centroParada == null)
            {
                Log.Warning($"Stop Center: {id} does not exits");
                return NotFound();
            }

            _context.CentroParada.Remove(centroParada);
            await _context.SaveChangesAsync();

            Log.Information($"Stop Center: {centroParada.Id} - {centroParada.Nombre} successfully deleted");

            return NoContent();
        }
    }
}
