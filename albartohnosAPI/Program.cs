using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using albartohnosAPI.Data;
using albartohnosAPI.Services;
using Serilog;

namespace albartohnosAPI {
    public class Program {
        public static void Main(string[] args) {
            try {
                // string url = "0.0.0.0";
                var builder = WebApplication.CreateBuilder(args);

                //Add Logger settings to write logs to a file using SeriLog
                Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt",
                    fileSizeLimitBytes: 10485760, // 10 MB
                    rollOnFileSizeLimit: true,
                    shared: true,
                    flushToDiskInterval: TimeSpan.FromSeconds(5))
                .CreateLogger();

                Log.Information("API is starting");

                // Add services to the container.

                builder.Services.AddControllers();
                builder.Services.AddScoped<TokenService>();
                // Read JWT settings from configuration
                var jwtSettings = builder.Configuration.GetSection("Jwt");
                var key = Encoding.UTF8.GetBytes(jwtSettings["Key"]);

                // Configure JWT authentication
                builder.Services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtSettings["Issuer"],
                        ValidAudience = jwtSettings["Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });

                // Configurar la conexión a MySQL
                builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseMySql(
                        builder.Configuration.GetConnectionString("MySQLConnection"),
                        new MySqlServerVersion(new Version(8, 0, 32)) // Cambia por la versión de tu servidor MySQL
                    )
                );

                // Configuration
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json") // Add your configuration sources as needed
                    .Build();

                /*
                    // Get certificate information from configuration
                    var certificatePath = configuration["Certificate:Path"];
                    var certificatePassword = configuration["Certificate:Password"];
                

                    // Specify the IP address and configure Kestrel with HTTPS and the specified certificate
                    builder.WebHost.UseKestrel(options =>
                    {
                        options.Listen(System.Net.IPAddress.Parse(url), 5000); // HTTP
                        options.Listen(System.Net.IPAddress.Parse(url), 7043, listenOptions =>
                        {

                            listenOptions.UseHttps(certificatePath, certificatePassword);

                        }); // HTTPS
                    });
                */

                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.MapControllers();

                app.Run();

                Log.Information("API is started");
            }
            catch (Exception ex){
                Log.Fatal(ex, "API turning off");
            }
            finally {
                Log.CloseAndFlush();
            }
        }
    }
}