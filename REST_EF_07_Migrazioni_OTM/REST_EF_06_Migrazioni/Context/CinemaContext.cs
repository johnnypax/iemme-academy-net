using Microsoft.EntityFrameworkCore;
using REST_EF_06_Migrazioni.Models;

namespace REST_EF_06_Migrazioni.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Film> Pellicole { get; set; }
        public DbSet<Categoria> Categorie { get; set; }
        public DbSet<Film_Categoria> Film_Categorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasIndex(f => f.Codice).IsUnique();
            modelBuilder.Entity<Categoria>().HasIndex(f => f.Nome).IsUnique();

            modelBuilder.Entity<Film_Categoria>()
                .HasOne(fc => fc.FilmNavigation)
                .WithMany(f => f.FilmCatList)
                .HasForeignKey(fc => fc.FilmRIF);

            modelBuilder.Entity<Film_Categoria>()
                .HasOne(fc => fc.CategoriaNavigation)
                .WithMany(c => c.FilmCatList)
                .HasForeignKey(fc => fc.CategoriaRIF);
        }
    }
}
