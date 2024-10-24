using ASP_WEB_05_Esercizio_Corsi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_05_Esercizio_Corsi.Context
{
    public class PoloFormativoContext : DbContext
    {
        public PoloFormativoContext(DbContextOptions<PoloFormativoContext> options) : base(options) { }

        public DbSet<Admin> Amministratori { get; set; }
    }
}
