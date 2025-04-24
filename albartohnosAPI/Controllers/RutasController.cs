﻿using System;
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
    public class RutasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rutas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ruta>>> GetRuta()
        {
            return await _context.Ruta.ToListAsync();
        }

        // GET: api/Rutas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ruta>> GetRuta(string id)
        {
            var ruta = await _context.Ruta.FindAsync(id);

            if (ruta == null)
            {
                return NotFound();
            }

            return ruta;
        }

        // PUT: api/Rutas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRuta(string id, Ruta ruta)
        {
            if (id != ruta.CodRuta)
            {
                return BadRequest();
            }

            _context.Entry(ruta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RutaExists(id))
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

        // POST: api/Rutas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ruta>> PostRuta(Ruta ruta)
        {
            _context.Ruta.Add(ruta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RutaExists(ruta.CodRuta))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRuta", new { id = ruta.CodRuta }, ruta);
        }

        // DELETE: api/Rutas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRuta(string id)
        {
            var ruta = await _context.Ruta.FindAsync(id);
            if (ruta == null)
            {
                return NotFound();
            }

            _context.Ruta.Remove(ruta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RutaExists(string id)
        {
            return _context.Ruta.Any(e => e.CodRuta == id);
        }
    }
}
