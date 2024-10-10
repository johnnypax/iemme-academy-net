
using Microsoft.EntityFrameworkCore;
using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Repos;
using REST_05_EF_Videoteche_Ref.Services;

namespace REST_05_EF_Videoteche_Ref
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

            #region Importanti per la configurazione del context

#if DEBUG
            builder.Services.AddDbContext<BlockbusterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
                );

            builder.Services.AddScoped<VideotecaRepo>();
            builder.Services.AddScoped<SupportoRepo>();

            builder.Services.AddScoped<VideotecaService>();
#else
            builder.Services.AddDbContext<BlockbusterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseProd"))
                );
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

            app.Run();
        }
    }
}
