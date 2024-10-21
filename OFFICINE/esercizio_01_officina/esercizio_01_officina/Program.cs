
using esercizio_01_officina.Context;
using esercizio_01_officina.Repositories;
using esercizio_01_officina.Services;
using Microsoft.EntityFrameworkCore;

namespace esercizio_01_officina
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Configurazione delle iniezioni

#if DEBUG
            builder.Services.AddDbContext<OfficinaContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DatabaseTest")
                )
            );

            builder.Services.AddScoped<ClienteRepo>();   //AddTransient, AddScoped
            builder.Services.AddScoped<InterventoRepo>();
            builder.Services.AddScoped<ClienteService>();
            builder.Services.AddScoped<InterventoService>();


#else
            builder.Services.AddDbContext<OfficinaContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DatabaseProd")
                )
            );

            builder.Services.AddScoped<ClienteRepo>();   //AddTransient, AddScoped
            builder.Services.AddScoped<ClienteService>();
#endif

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            #region Configurazione di dev per CORS

#if DEBUG
            app.UseCors(builder => 
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
                );
#endif

            #endregion

            app.Run();
        }
    }
}
