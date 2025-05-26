using albartohnosAPI.Data;
using albartohnosAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Text;
using System.Security.Cryptography;

namespace albartohnosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly TokenService _tokenService;

        public AuthController(ApplicationDbContext context, TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] Requests.LoginRequest loginRequest)
        {
            Log.Information($"Login API called with username: {loginRequest.Login}");

            var user = await Negocio.GetUserByLogin(loginRequest.Login);

            if (user is null)
            {
                Log.Warning($"Invalid login attempt for username: {loginRequest.Login}");
                return Unauthorized("Invalid credentials");
            }

            if (!Negocio.LoginUser(loginRequest.Login, loginRequest.Password))
            {
                Log.Warning($"Invalid login attempt for username: {loginRequest.Login}");
                return Unauthorized("Invalid credentials");
            }


            var token = _tokenService.CreateToken(user.Login, user.Perfil);

            Log.Information($"Login successful for username: {user.Login}, Token: {token}");

            return Ok(new { Token = token });
        }

        // GET: api/auth/checkusernameavailability
        [HttpGet("checkusernametaken")]
        public async Task<ActionResult<bool>> CheckUsernameTaken(string login)
        {
            try
            {
                Log.Information($"CheckUsernameTaken API called with username: {login}");

                login = login.ToLower();
                var result = await Negocio.CheckUsernameTaken(login);

                Log.Information($"CheckUsernameAvailability API response: {result}");

                return result;
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred in CheckUsernameAvailability API: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // POST: api/auth/hasher
        [HttpPost("hasher")]
        public ActionResult<string> HashtoSHA256(string password)
        {
            // Validador sencillo de que no llega contraseña
            if (password == null || string.IsNullOrEmpty(password))
            {
                return BadRequest("Password null or empty");

            }

            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;

            foreach (byte x in hash)
            {
                hashString += string.Format("{0:x2}", x);
            }

            return Ok(hashString);
        }
    }
}
