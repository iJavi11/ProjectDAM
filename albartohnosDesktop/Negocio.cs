using albartohnosDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace albartohnosDesktop
{
    public class Negocio
    {
        // URL de la API
        private static string BaseURL = "https://localhost:7256/api/";
        private static string Token;

        static Negocio()
        {

        }

        private static HttpClient CreateHttpClientWithToken()
        {
            // Create a new HttpClient instance
            var client = new HttpClient();
            // Set the base address of the API
            client.BaseAddress = new Uri(BaseURL);

            // Set the Authorization header with the token
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);
            return client;
        }

        #region - Métodos de Estados de Ruta -

        public static async Task<List<EstadoRuta>> ObtenerEstadosRuta()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}EstadosRuta");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var estadosRuta = JsonSerializer.Deserialize<List<EstadoRuta>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return estadosRuta;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Estados de Parada -

        public static async Task<List<EstadoParada>> ObtenerEstadosParada()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}EstadosParada");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var estadosParada = JsonSerializer.Deserialize<List<EstadoParada>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return estadosParada;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Estados de Pedido -

        public static async Task<List<EstadoPedido>> ObtenerEstadosPedido()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}EstadosPedido");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var estadosPedido = JsonSerializer.Deserialize<List<EstadoPedido>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return estadosPedido;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Perfiles -

        public static async Task<List<Perfil>> ObtenerPerfiles()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Perfiles");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var perfiles = JsonSerializer.Deserialize<List<Perfil>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return perfiles;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Tipos de Centro -

        public static async Task<List<TipoCentro>> ObtenerTiposCentro()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}TiposCentro");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var tiposCentro = JsonSerializer.Deserialize<List<TipoCentro>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return tiposCentro;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Tipos de Pedido -

        public static async Task<List<TipoPedido>> ObtenerTiposPedido()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}TiposPedido");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var tiposPedido = JsonSerializer.Deserialize<List<TipoPedido>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return tiposPedido;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        #endregion

        #region - Métodos de Usuario -

        public async static Task<List<Usuario>> ObtenerUsuarios()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Usuarios");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var usuarios = JsonSerializer.Deserialize<List<Usuario>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return usuarios;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Usuario>> ObtenerConductores()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Usuarios/Conductores");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var usuarios = JsonSerializer.Deserialize<List<Usuario>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return usuarios;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Usuario>> ObtenerConductoresActivos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Usuarios/Conductores/Activos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var usuarios = JsonSerializer.Deserialize<List<Usuario>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return usuarios;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<string> IniciarSesion(string login, string passwd)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"{BaseURL}Auth/login";
                // Crea el objeto JSON para enviar al servidor
                LoginRequest loginRequest = new LoginRequest(login, passwd);

                // Serialize the login request object using System.Text.Json
                var jsonRequest = JsonSerializer.Serialize(loginRequest);

                // Create the HTTP content with the JSON string
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                // Post the request
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response into a dictionary
                    var tokenDictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(responseContent);

                    // Access the value associated with the "token" key
                    Token = tokenDictionary["token"];
                    return "Successfully authenticated";
                }
                else
                {
                    return $"Error in response {response.StatusCode} {response.ReasonPhrase}";
                }
            }
        }
        public async static Task<Usuario> ObtenerUsuario(string login)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"Usuarios/{login}");

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a dictionary
                    var user = JsonSerializer.Deserialize<Usuario>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return user;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarUsuario(Usuario usuario)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        usuario.Login,
                        usuario.Password,
                        usuario.Perfil,
                        usuario.Nombre,
                        usuario.Apellidos,
                        usuario.Dni,
                        usuario.Nss,
                        usuario.Tlf,
                        usuario.Email,
                        usuario.Ccaa,
                        usuario.Localidad,
                        usuario.Direccion,
                        usuario.Activo,
                        FechaAlta = usuario.FechaAlta?.ToString("yyyy-MM-dd"),
                        FechaBaja = usuario.FechaBaja?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Usuarios/{usuario.Login}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearUsuario(Usuario usuario)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        usuario.Login,
                        usuario.Password,
                        usuario.Perfil,
                        usuario.Nombre,
                        usuario.Apellidos,
                        usuario.Dni,
                        usuario.Nss,
                        usuario.Tlf,
                        usuario.Email,
                        usuario.Ccaa,
                        usuario.Localidad,
                        usuario.Direccion,
                        usuario.Activo,
                        FechaAlta = usuario.FechaAlta?.ToString("yyyy-MM-dd"),
                        FechaBaja = usuario.FechaBaja?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Usuarios", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarUsuario(string login)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Usuarios/{login}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Vehículo -

        public async static Task<List<Vehiculo>> ObtenerVehiculos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Vehiculos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var vehiculos = JsonSerializer.Deserialize<List<Vehiculo>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return vehiculos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Vehiculo>> ObtenerVehiculosActivos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Vehiculos/Activos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var vehiculos = JsonSerializer.Deserialize<List<Vehiculo>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return vehiculos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarVehiculo(Vehiculo vehiculo)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        vehiculo.Matricula,
                        vehiculo.Marca,
                        vehiculo.Modelo,
                        vehiculo.Descripcion,
                        vehiculo.Capacidad,
                        vehiculo.Activo,
                        FechaAlta = vehiculo.FechaAlta?.ToString("yyyy-MM-dd"),
                        FechaBaja = vehiculo.FechaBaja?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Vehiculos/{vehiculo.Matricula}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearVehiculo(Vehiculo vehiculo)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        vehiculo.Matricula,
                        vehiculo.Marca,
                        vehiculo.Modelo,
                        vehiculo.Descripcion,
                        vehiculo.Capacidad,
                        vehiculo.Activo,
                        FechaAlta = vehiculo.FechaAlta?.ToString("yyyy-MM-dd"),
                        FechaBaja = vehiculo.FechaBaja?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Vehiculos", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarVehiculo(string matricula)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Vehiculos/{matricula}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Centros de Parada -

        public async static Task<List<CentroParada>> ObtenerCentrosParada()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}CentrosParada");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var centrosParada = JsonSerializer.Deserialize<List<CentroParada>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return centrosParada;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<CentroParada>> ObtenerAlmacenes()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}CentrosParada/Almacenes");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var almacenes = JsonSerializer.Deserialize<List<CentroParada>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return almacenes;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarCentroParada(CentroParada centroParada)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        centroParada.Id,
                        centroParada.Nombre,
                        centroParada.TipoCentro,
                        centroParada.Tlf,
                        centroParada.Email,
                        centroParada.Ccaa,
                        centroParada.Localidad,
                        centroParada.Direccion
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}CentrosParada/{centroParada.Id}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearCentroParada(CentroParada centroParada)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        centroParada.Id,
                        centroParada.Nombre,
                        centroParada.TipoCentro,
                        centroParada.Tlf,
                        centroParada.Email,
                        centroParada.Ccaa,
                        centroParada.Localidad,
                        centroParada.Direccion
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}CentrosParada", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarCentroParada(string id)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}CentrosParada/{id}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Producto -

        public async static Task<List<Producto>> ObtenerProductos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Productos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var productos = JsonSerializer.Deserialize<List<Producto>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return productos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Producto>> ObtenerProductosActivos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Productos/Activos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var productos = JsonSerializer.Deserialize<List<Producto>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return productos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarProducto(Producto producto)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        producto.Sku,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.Activo
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Productos/{producto.Sku}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearProducto(Producto producto)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        producto.Sku,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.Activo
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Productos", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarProducto(string sku)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Productos/{sku}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Stock -

        public async static Task<List<Stock>> ObtenerStockProducto(string skuProducto)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Stock/Producto/{skuProducto}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var stock = JsonSerializer.Deserialize<List<Stock>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return stock;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Stock>> ObtenerStockAlmacen(string idAlmacen)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Stock/Almacen/{idAlmacen}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var stock = JsonSerializer.Deserialize<List<Stock>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return stock;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarStock(Stock stock)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        stock.IdAlmacen,
                        stock.SkuProducto,
                        stock.Cantidad
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Stock/{stock.IdAlmacen}/{stock.SkuProducto}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearStock(Stock stock)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        stock.IdAlmacen,
                        stock.SkuProducto,
                        stock.Cantidad
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Stock", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarStock(string idAlmacen, string skuProducto)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Stock/{idAlmacen}/{skuProducto}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Ruta -

        public async static Task<List<Ruta>> ObtenerRutas()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Rutas");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var rutas = JsonSerializer.Deserialize<List<Ruta>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return rutas;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarRuta(Ruta ruta)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        ruta.CodRuta,
                        ruta.Estado,
                        ruta.Descripcion,
                        ruta.Conductor,
                        ruta.Vehiculo,
                        FechaPrevInicio = ruta.FechaPrevInicio?.ToString("yyyy-MM-dd"),
                        FechaPrevFin = ruta.FechaPrevFin?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Rutas/{ruta.CodRuta}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearRuta(Ruta ruta)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        ruta.CodRuta,
                        ruta.Estado,
                        ruta.Descripcion,
                        ruta.Conductor,
                        ruta.Vehiculo,
                        FechaPrevInicio = ruta.FechaPrevInicio?.ToString("yyyy-MM-dd"),
                        FechaPrevFin = ruta.FechaPrevFin?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Rutas", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarRuta(string codRuta)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Rutas/{codRuta}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Parada -

        public async static Task<List<Parada>> ObtenerParadas()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Paradas");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var paradas = JsonSerializer.Deserialize<List<Parada>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return paradas;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Parada>> ObtenerParadasByRuta(string codRuta)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Paradas/Ruta/{codRuta}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var paradas = JsonSerializer.Deserialize<List<Parada>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return paradas;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarParada(Parada parada)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        parada.Id,
                        parada.Ruta,
                        parada.CentroParada,
                        parada.Orden,
                        parada.Estado,
                        FechaPrev = parada.FechaPrev?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Paradas/{parada.Id}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearParada(Parada parada)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        parada.Ruta,
                        parada.CentroParada,
                        parada.Orden,
                        parada.Estado,
                        FechaPrev = parada.FechaPrev?.ToString("yyyy-MM-dd")
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Paradas", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarParada(int id)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Paradas/{id}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion

        #region - Métodos de Pedido -

        public async static Task<List<Pedido>> ObtenerPedidos()
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Pedidos");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var pedidos = JsonSerializer.Deserialize<List<Pedido>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return pedidos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<List<Pedido>> ObtenerPedidosByParada(int idParada)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the GET request to the endpoint
                HttpResponseMessage response = await client.GetAsync($"{BaseURL}Pedidos/Parada/{idParada}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response into a list of Vehiculo objects
                    var pedidos = JsonSerializer.Deserialize<List<Pedido>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return pedidos;
                }
                else
                {
                    // Print the error status code and reason phrase
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async static Task<bool> EditarPedido(Pedido pedido)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        pedido.CodPedido,
                        pedido.SkuProducto,
                        pedido.Tipo,
                        pedido.Estado,
                        pedido.Cantidad,
                        pedido.Precio,
                        pedido.IdParada
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Send the PUT request to update the vehicle
                HttpResponseMessage response = await client.PutAsync($"{BaseURL}Pedidos/{pedido.CodPedido}", content);
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> CrearPedido(Pedido pedido)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Serialize the Vehiculo object to JSON
                var json = JsonSerializer.Serialize(new
                    {
                        pedido.CodPedido,
                        pedido.SkuProducto,
                        pedido.Tipo,
                        pedido.Estado,
                        pedido.Cantidad,
                        pedido.Precio,
                        pedido.IdParada
                    }
                );
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request to create a new vehicle
                HttpResponseMessage response = await client.PostAsync($"{BaseURL}Pedidos", content);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async static Task<bool> BorrarPedido(string codPedido)
        {
            HttpClient client = CreateHttpClientWithToken();
            try
            {
                // Send the DELETE request to delete the vehicle
                HttpResponseMessage response = await client.DeleteAsync($"{BaseURL}Pedidos/{codPedido}");
                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, Details: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        #endregion
    }
}
