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
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Stock
        [HttpGet]
        public async Task<List<Stock>> GetStock()
        {
            // return await _context.Stock.ToListAsync();
            return await Negocio.GetAllStock();
        }

        // GET: api/Stock/Producto/PEL-001
        [HttpGet("Producto/{skuProducto}")]
        public async Task<List<Stock>> GetStockByProducto(string skuProducto)
        {
            return await Negocio.GetAllStockByProduct(skuProducto);
        }

        // GET: api/Stock/Almacen/1
        [HttpGet("Almacen/{idAlmacen}")]
        public async Task<List<Stock>> GetStockByAlmacen(string idAlmacen)
        {
            return await Negocio.GetAllStockByWarehouse(idAlmacen);
        }

        // PUT: api/Stock/1/PEL-001
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{idAlmacen}/{skuProducto}")]
        public async Task<IActionResult> PutStock(string idAlmacen, string skuProducto, Stock stock)
        {
            if (idAlmacen != stock.IdAlmacen || skuProducto != stock.SkuProducto)
            {
                return BadRequest();
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Stock successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.StockExists(idAlmacen, skuProducto))
                {
                    Log.Warning($"Stock Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing the Stock: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stock
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            _context.Stock.Add(stock);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Stock successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.StockExists(stock.IdAlmacen, stock.SkuProducto))
                {
                    Log.Warning($"Stock already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating the Stock: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction(
                "GetStock", 
                new { idAlmacen = stock.IdAlmacen, skuProducto = stock.SkuProducto }, 
                stock
            );
        }

        // DELETE: api/Stock/1/PEL-001
        [HttpDelete("{idAlmacen}/{skuProducto}")]
        public async Task<IActionResult> DeleteStock(string idAlmacen, string skuProducto)
        {
            var stock = await _context.Stock
                .FirstOrDefaultAsync(s => 
                    s.IdAlmacen == idAlmacen && s.SkuProducto == skuProducto
                );

            if (stock == null)
            {
                Log.Warning($"Stockdoes not exists");
                return NotFound();
            }

            _context.Stock.Remove(stock);
            await _context.SaveChangesAsync();

            Log.Information($"Stock successfully deleted");

            return NoContent();
        }
    }
}
