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
        public static async Task<Usuario?> GetUserByLogin(string login)
        {
            return await GetContext().Usuario.FirstOrDefaultAsync(x => x.Login == login);
        }

        #endregion

        #region - Métodos de Vehículo -

        public static async Task<List<Vehiculo>> GetAllVehicles()
        {
            return await GetContext().Vehiculo.ToListAsync();
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
    }
}
