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
    public class RutasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rutas
        [HttpGet]
        public async Task<List<Ruta>> GetAllRutas()
        {
            return await Negocio.GetAllRoutes();
        }

        // GET: api/Rutas/ruta01
        [HttpGet("{codRuta}")]
        public async Task<ActionResult<Ruta>> GetRutaByCodRuta(string codRuta)
        {
            var ruta = await Negocio.GetRouteByCodRoute(codRuta);

            if (ruta == null)
            {
                return NotFound();
            }

            return ruta;
        }

        // PUT: api/Rutas/ruta01
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{codRuta}")]
        public async Task<IActionResult> PutRuta(string codRuta, Ruta ruta)
        {
            if (codRuta != ruta.CodRuta)
            {
                return BadRequest();
            }

            _context.Entry(ruta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Route: {ruta.CodRuta} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.RouteExists(codRuta))
                {
                    Log.Warning($"Route -- {ruta.CodRuta} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing a route: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rutas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ruta>> PostRuta(Ruta ruta)
        {
            _context.Ruta.Add(ruta);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Route: {ruta.CodRuta} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.RouteExists(ruta.CodRuta))
                {
                    Log.Warning($"Route -- {ruta.CodRuta} -- already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating a route: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetRutaByCodRuta", new { codRuta = ruta.CodRuta }, ruta);
        }

        // DELETE: api/Rutas/ruta01
        [HttpDelete("{codRuta}")]
        public async Task<IActionResult> DeleteRuta(string codRuta)
        {
            var ruta = await _context.Ruta.FindAsync(codRuta);
            if (ruta == null)
            {
                Log.Warning($"Route: {codRuta} does not exists");
                return NotFound();
            }

            _context.Ruta.Remove(ruta);
            await _context.SaveChangesAsync();

            Log.Information($"Route: {ruta.CodRuta} successfully deleted");

            return NoContent();
        }
    }
}
