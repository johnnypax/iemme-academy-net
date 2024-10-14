using ASP_WEB_03_Clienti.Context;
using ASP_WEB_03_Clienti.Repositories;
using ASP_WEB_03_Clienti.Service;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_03_Clienti
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Cliente}/{action=Lista}/{varCodice?}");

            app.Run();
        }
    }
}
