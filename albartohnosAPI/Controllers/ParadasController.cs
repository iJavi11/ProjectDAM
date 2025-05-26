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
    public class ParadasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ParadasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Paradas
        [HttpGet]
        public async Task<List<Parada>> GetAllParadas()
        {
            return await Negocio.GetAllStops();
        }

        // GET: api/Paradas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parada>> GetParadaById(int id)
        {
            var parada = await Negocio.GetStopById(id);

            if (parada == null)
            {
                return NotFound();
            }

            return parada;
        }

        // GET: api/Paradas/Ruta/RUTA-001
        [HttpGet("Ruta/{codRuta}")]
        public async Task<ActionResult<List<Parada>>> GetParadasByRuta(string codRuta)
        {
            var paradas = await Negocio.GetStopsByRoute(codRuta);

            if (paradas == null)
            {
                return NotFound();
            }

            return paradas;
        }

        // PUT: api/Paradas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParada(int id, Parada parada)
        {
            if (id != parada.Id)
            {
                return BadRequest();
            }

            _context.Entry(parada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Stop: {parada.Id} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.StopExists(id))
                {
                    Log.Warning($"Stop -- {parada.Id} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing a stop: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Paradas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parada>> PostParada(Parada parada)
        {
            _context.Parada.Add(parada);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Stop: {parada.Id} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.StopExists(parada.Id))
                {
                    Log.Warning($"Stop -- {parada.Id} -- already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating a stop: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetParadaById", new { id = parada.Id }, parada);
        }

        // DELETE: api/Paradas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParada(int id)
        {
            var parada = await _context.Parada.FindAsync(id);
            if (parada == null)
            {
                Log.Warning($"Stop: {id} does not exists");
                return NotFound();
            }

            _context.Parada.Remove(parada);
            await _context.SaveChangesAsync();

            Log.Information($"Stop: {parada.Id} successfully deleted");

            return NoContent();
        }
    }
}
