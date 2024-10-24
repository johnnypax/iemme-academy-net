using ASP_WEB_05_Esercizio_Corsi.Context;
using ASP_WEB_05_Esercizio_Corsi.Repos;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_05_Esercizio_Corsi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PoloFormativoContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
            );

            builder.Services.AddScoped<AdminRepo>();
            builder.Services.AddScoped<CorsoRepo>();
            builder.Services.AddScoped<AdminService>();
            builder.Services.AddScoped<CorsoService>();
            builder.Services.AddScoped<CorsoApiService>();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Auth}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
