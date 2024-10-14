using esercizio_01_officina.Models;
using Microsoft.EntityFrameworkCore;

namespace esercizio_01_officina.Context
{
    public class OfficinaContext : DbContext
    {
        public OfficinaContext(DbContextOptions<OfficinaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Intervento> Interventi { get; set; }
    }
}
