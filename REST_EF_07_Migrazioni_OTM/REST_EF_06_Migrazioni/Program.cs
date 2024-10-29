
using Microsoft.EntityFrameworkCore;
using REST_EF_06_Migrazioni.Context;
using REST_EF_06_Migrazioni.Repos;
using REST_EF_06_Migrazioni.Services;

namespace REST_EF_06_Migrazioni
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

            builder.Services.AddDbContext<CinemaContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DatabaseTest")
                )
            );

            builder.Services.AddScoped<FilmRepo>();
            builder.Services.AddScoped<CategoriaRepo>();
            builder.Services.AddScoped<FilmCategoriaRepo>();
            builder.Services.AddScoped<FilmService>();
            builder.Services.AddScoped<CategoriaService>();
            builder.Services.AddScoped<FilmCategoriaService>();

            #region Configurazione del context

            builder.Services.AddDbContext<CinemaContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DatabaseTest")
                )
            );

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

            app.Run();
        }
    }
}
