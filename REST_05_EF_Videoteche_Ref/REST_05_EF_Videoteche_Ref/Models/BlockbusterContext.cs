using Microsoft.EntityFrameworkCore;

namespace REST_05_EF_Videoteche_Ref.Models
{
    public class BlockbusterContext : DbContext
    {
        public BlockbusterContext(DbContextOptions<BlockbusterContext> options) : base(options)
        { 
        }

        public DbSet<Videoteca> Videoteche { get; set; }
        public DbSet<Supporto> Supporti { get; set; }
    }
}
