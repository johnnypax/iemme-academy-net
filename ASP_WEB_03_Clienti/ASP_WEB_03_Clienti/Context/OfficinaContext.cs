using ASP_WEB_03_Clienti.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_03_Clienti.Context
{
    public class OfficinaContext : DbContext
    {
        public OfficinaContext(DbContextOptions<OfficinaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clienti { get; set; }
    }
}
