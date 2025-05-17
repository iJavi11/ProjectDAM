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
        /*
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
        */
        #endregion
    }
}
