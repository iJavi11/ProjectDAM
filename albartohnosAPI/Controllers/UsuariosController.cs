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
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<List<Usuario>> GetAllUsuarios()
        {
            return await Negocio.GetAllUsers();
        }

        // GET: api/Usuarios/Conductores
        [HttpGet("Conductores")]
        public async Task<List<Usuario>> GetAllConductores()
        {
            return await Negocio.GetAllDrivers();
        }

        // GET: api/Usuarios/Conductores
        [HttpGet("Conductores/Activos")]
        public async Task<List<Usuario>> GetConductoresActivos()
        {
            return await Negocio.GetActiveDrivers();
        }

        // GET: api/Usuarios/admin
        [HttpGet("{login}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string login)
        {
            var usuario = await Negocio.GetUserByLogin(login);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/admin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{login}")]
        public async Task<IActionResult> PutUsuario(string login, Usuario usuario)
        {
            if (login != usuario.Login)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"User: {usuario.Login} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.UsuarioExists(login))
                {
                    Log.Warning($"User -- {usuario.Login} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing an user: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"User: {usuario.Login} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.UsuarioExists(usuario.Login))
                {
                    Log.Warning($"User -- {usuario.Login} -- already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating an user: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetUsuario", new { login = usuario.Login }, usuario);
        }

        // DELETE: api/Usuarios/admin
        [HttpDelete("{login}")]
        public async Task<IActionResult> DeleteUsuario(string login)
        {
            var usuario = await _context.Usuario.FindAsync(login);
            if (usuario == null)
            {
                Log.Warning($"User: {login} does not exists");
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            Log.Information($"User: {usuario.Login} successfully deleted");

            return NoContent();
        }
    }
}
