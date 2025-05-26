using albartohnosAPI.Data;
using albartohnosAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace albartohnosAPI
{
    public class Negocio
    {
        public Negocio(){}
        public static ApplicationDbContext GetContext()
        {
            return new ApplicationDbContext();
        }

        #region - Métodos de Estados de Ruta -

        public static async Task<List<EstadoRuta>> GetRouteStates()
        {
            return await GetContext().EstadoRuta.ToListAsync();
        }

        #endregion

        #region - Métodos de Estados de Parada -

        public static async Task<List<EstadoParada>> GetStopStates()
        {
            return await GetContext().EstadoParada.ToListAsync();
        }

        #endregion

        #region - Métodos de Estados de Pedido -

        public static async Task<List<EstadoPedido>> GetOrderStates()
        {
            return await GetContext().EstadoPedido.ToListAsync();
        }

        #endregion

        #region - Métodos de Tipos de Centro -

        public static async Task<List<TipoCentro>> GetStopCenterTypes()
        {
            return await GetContext().TipoCentro.ToListAsync();
        }

        #endregion

        #region - Métodos de Tipos de Pedido -

        public static async Task<List<TipoPedido>> GetOrderTypes()
        {
            return await GetContext().TipoPedido.ToListAsync();
        }

        #endregion

        #region - Métodos de Perfiles -

        public static async Task<List<Perfil>> GetUserProfiles()
        {
            return await GetContext().Perfil.ToListAsync();
        }

        #endregion

        #region - Métodos de Usuario -

        public static async Task<List<Usuario>> GetAllUsers()
        {
            return await GetContext().Usuario.ToListAsync();
        }
        public static async Task<List<Usuario>> GetAllDrivers()
        {
            return await GetContext().Usuario.Where(e => e.Perfil == 3).ToListAsync();
        }
        public static async Task<List<Usuario>> GetActiveDrivers()
        {
            return await GetContext().Usuario.Where(e => e.Perfil == 3 && e.Activo == 1).ToListAsync();
        }
        public static async Task<Usuario?> GetUserByLogin(string login)
        {
            return await GetContext().Usuario.FirstOrDefaultAsync(x => x.Login == login);
        }
        public static bool LoginUser(string login, string passwordHash)
        {
            if (GetContext().Usuario.Any(x => x.Login == login && x.Password == passwordHash))
            {
                return true;
            }
            return false;
        }
        public static async Task<bool> CheckUsernameTaken(string login)
        {
            login = login.ToLower();
            var result = await GetContext().Usuario.AnyAsync(x => x.Login == login);

            return result;
        }
        public static bool UsuarioExists(string login)
        {
            return GetContext().Usuario.Any(e => e.Login == login);
        }

        #endregion

        #region - Métodos de Vehículo -

        public static async Task<List<Vehiculo>> GetAllVehicles()
        {
            return await GetContext().Vehiculo.ToListAsync();
        }
        public static async Task<List<Vehiculo>> GetActiveVehicles()
        {
            return await GetContext().Vehiculo.Where(e => e.Activo == 1).ToListAsync();
        }
        public static async Task<Vehiculo> GetVehicleByPlate(string matricula)
        {
            return await GetContext().Vehiculo.FindAsync(matricula);
        }
        public static bool VehicleExists(string matricula)
        {
            return GetContext().Vehiculo.Any(e => e.Matricula == matricula);
        }

        #endregion

        #region - Métodos de Centros de Parada -

        public static async Task<List<CentroParada>> GetAllStopCenters()
        {
            return await GetContext().CentroParada.ToListAsync();
        }
        public static async Task<List<CentroParada>> GetAllWarehouses()
        {
            return await GetContext().CentroParada.Where(cp => cp.TipoCentro == 1).ToListAsync();
        }
        public static async Task<CentroParada> GetStopCenterById(string id)
        {
            return await GetContext().CentroParada.FindAsync(id);
        }
        public static bool StopCenterExists(string id)
        {
            return GetContext().CentroParada.Any(e => e.Id == id);
        }

        #endregion

        #region - Métodos de Producto -

        public static async Task<List<Producto>> GetAllProducts()
        {
            return await GetContext().Producto.ToListAsync();
        }
        public static async Task<List<Producto>> GetActiveProducts()
        {
            return await GetContext().Producto.Where(e => e.Activo == 1).ToListAsync();
        }
        public static async Task<Producto> GetProductBySku(string sku)
        {
            return await GetContext().Producto.FindAsync(sku);
        }
        public static bool ProductExists(string sku)
        {
            return GetContext().Producto.Any(e => e.Sku == sku);
        }

        #endregion

        #region - Métodos de Stock -

        public static async Task<List<Stock>> GetAllStock()
        {
            return await GetContext().Stock.ToListAsync();
        }
        public static async Task<List<Stock>> GetAllStockByProduct(string skuProducto)
        {
            return await GetContext().Stock.Where(s => s.SkuProducto == skuProducto).ToListAsync();
        }
        public static async Task<List<Stock>> GetAllStockByWarehouse(string idAlmacen)
        {
            return await GetContext().Stock.Where(s => s.IdAlmacen == idAlmacen).ToListAsync();
        }
        public static bool StockExists(string idAlmacen, string skuProducto)
        {
            return GetContext().Stock.Any(e => e.IdAlmacen == idAlmacen && e.SkuProducto == skuProducto);
        }

        #endregion

        #region - Métodos de Ruta -

        public static async Task<List<Ruta>> GetAllRoutes()
        {
            return await GetContext().Ruta.ToListAsync();
        }
        public static async Task<Ruta> GetRouteByCodRoute(string codRuta)
        {
            return await GetContext().Ruta.FindAsync(codRuta);
        }
        public static bool RouteExists(string codRuta)
        {
            return GetContext().Ruta.Any(e => e.CodRuta == codRuta);
        }

        #endregion

        #region - Métodos de Parada -

        public static async Task<List<Parada>> GetAllStops()
        {
            return await GetContext().Parada.ToListAsync();
        }
        public static async Task<Parada> GetStopById(int id)
        {
            return await GetContext().Parada.FindAsync(id);
        }
        public static async Task<List<Parada>> GetStopsByRoute(string codRuta)
        {
            return await GetContext().Parada.Where(e => e.Ruta == codRuta).ToListAsync();
        }
        public static bool StopExists(int id)
        {
            return GetContext().Parada.Any(e => e.Id == id);
        }

        #endregion

        #region - Métodos de Pedido -

        public static async Task<List<Pedido>> GetAllOrders()
        {
            return await GetContext().Pedido.ToListAsync();
        }
        public static async Task<Pedido> GetStopByCodOrder(string codPedido)
        {
            return await GetContext().Pedido.FindAsync(codPedido);
        }
        public static async Task<List<Pedido>> GetOrdersByStop(int idParada)
        {
            return await GetContext().Pedido.Where(e => e.IdParada == idParada).ToListAsync();
        }
        public static bool OrderExists(string codPedido)
        {
            return GetContext().Pedido.Any(e => e.CodPedido == codPedido);
        }

        #endregion

    }
}
