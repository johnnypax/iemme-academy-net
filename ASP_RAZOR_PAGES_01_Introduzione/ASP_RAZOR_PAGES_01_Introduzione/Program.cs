using ASP_RAZOR_PAGES_01_Introduzione.Context;
using ASP_RAZOR_PAGES_01_Introduzione.Repositories;
using ASP_RAZOR_PAGES_01_Introduzione.Service;
using Microsoft.EntityFrameworkCore;

namespace ASP_RAZOR_PAGES_01_Introduzione
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<OfficinaContext>(
               options => options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DatabaseTest")
               )
            );

            builder.Services.AddScoped<ClienteRepo>();
            builder.Services.AddScoped<ClienteService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
