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
    public class VehiculosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehiculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<List<Vehiculo>> GetAllVehiculos()
        {
            return await Negocio.GetAllVehicles();
        }

        // GET: api/Vehiculos/Activos
        [HttpGet("Activos")]
        public async Task<List<Vehiculo>> GetVehiculosActivos()
        {
            return await Negocio.GetActiveVehicles();
        }

        // GET: api/Vehiculos/7744GSN
        [HttpGet("{matricula}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculoByMatricula(string matricula)
        {
            var vehiculo = await Negocio.GetVehicleByPlate(matricula);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        // PUT: api/Vehiculos/7744GSN
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{matricula}")]
        public async Task<IActionResult> PutVehiculo(string matricula, Vehiculo vehiculo)
        {
            if (matricula != vehiculo.Matricula)
            {
                return BadRequest();
            }

            _context.Entry(vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Vehicle: {vehiculo.Matricula} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.VehicleExists(matricula))
                {
                    Log.Warning($"Vehicle -- {vehiculo.Matricula} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing a vehicle: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo vehiculo)
        {
            _context.Vehiculo.Add(vehiculo);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Vehicle: {vehiculo.Matricula} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.VehicleExists(vehiculo.Matricula))
                {
                    Log.Warning($"Vehicle -- {vehiculo.Matricula} -- already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating a vehicle: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetVehiculoByMatricula", new { matricula = vehiculo.Matricula }, vehiculo);
        }

        // DELETE: api/Vehiculos/7744GSN
        [HttpDelete("{matricula}")]
        public async Task<IActionResult> DeleteVehiculo(string matricula)
        {
            var vehiculo = await Negocio.GetVehicleByPlate(matricula);
            if (vehiculo == null)
            {
                Log.Warning($"Vehicle: {matricula} does not exists");
                return NotFound();
            }

            _context.Vehiculo.Remove(vehiculo);
            await _context.SaveChangesAsync();

            Log.Information($"Vehicle: {vehiculo.Matricula} successfully deleted");

            return NoContent();
        }
    }
}
