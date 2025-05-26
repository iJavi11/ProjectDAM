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
    public class PedidosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PedidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedidos
        [HttpGet]
        public async Task<List<Pedido>> GetAllPedidos()
        {
            return await Negocio.GetAllOrders();
        }

        // GET: api/Pedidos/ENT-001
        [HttpGet("{codPedido}")]
        public async Task<ActionResult<Pedido>> GetPedidoByCodPedido(string codPedido)
        {
            var pedido = await Negocio.GetStopByCodOrder(codPedido);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        // GET: api/Pedidos/Parada/ENT-001
        [HttpGet("Parada/{idParada}")]
        public async Task<ActionResult<List<Pedido>>> GetPedidosByParada(int idParada)
        {
            var pedidos = await Negocio.GetOrdersByStop(idParada);

            if (pedidos == null)
            {
                return NotFound();
            }

            return pedidos;
        }

        // PUT: api/Pedidos/ENT-001
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{codPedido}")]
        public async Task<IActionResult> PutPedido(string codPedido, Pedido pedido)
        {
            if (codPedido != pedido.CodPedido)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Order: {pedido.CodPedido} successfully updated");
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                if (!Negocio.OrderExists(codPedido))
                {
                    Log.Warning($"Order -- {pedido.CodPedido} -- Not Found");
                    return NotFound();
                }
                else
                {
                    Log.Error($"An error occurred while editing aan order: {dbEx.Message}");
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
            try
            {
                await _context.SaveChangesAsync();
                Log.Information($"Order: {pedido.CodPedido} successfully created");
            }
            catch (DbUpdateException dbEx)
            {
                if (Negocio.OrderExists(pedido.CodPedido))
                {
                    Log.Warning($"Order -- {pedido.CodPedido} -- already exists");
                    return Conflict();
                }
                else
                {
                    Log.Error($"An error occurred while creating an order: {dbEx.Message}");
                    throw;
                }
            }

            return CreatedAtAction("GetPedidoByCodPedido", new { codPedido = pedido.CodPedido }, pedido);
        }

        // DELETE: api/Pedidos/5
        [HttpDelete("{codPedido}")]
        public async Task<IActionResult> DeletePedido(string codPedido)
        {
            var pedido = await _context.Pedido.FindAsync(codPedido);
            if (pedido == null)
            {
                Log.Warning($"Order: {codPedido} does not exists");
                return NotFound();
            }

            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();

            Log.Information($"Order: {pedido.CodPedido} successfully deleted");

            return NoContent();
        }
    }
}
