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
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<List<Producto>> GetProductos()
        {
            return await Negocio.GetAllProducts();
        }

        // GET: api/Productos/Activos
        [HttpGet("Activos")]
        public async Task<List<Producto>> GetProductosActivos()
        {
            return await Negocio.GetActiveProducts();
        }

        // GET: api/Productos/PEL-001
        [HttpGet("{sku}")]
        public async Task<ActionResult<Producto>> GetProductoBySku(string sku)
        {
            var producto = await Negocio.GetProductBySku(sku);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        // PUT: api/Productos/PEL-001
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{sku}")]
        public async Task<IActionResult> PutProducto(string sku, Producto producto)
        {
            if (sku != producto.Sku)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Product: {producto.Sku} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.ProductExists(sku))
                {
                    Log.Warning($"Product -- {producto.Sku} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing a product: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Productos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Producto.Add(producto);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Product: {producto.Sku} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.ProductExists(producto.Sku))
                {
                    Log.Warning($"Product -- {producto.Sku} -- already exits");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while editing a product: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetProductoBySku", new { sku = producto.Sku }, producto);
        }

        // DELETE: api/Productos/PEL-001
        [HttpDelete("{sku}")]
        public async Task<IActionResult> DeleteProducto(string sku)
        {
            var producto = await _context.Producto.FindAsync(sku);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
