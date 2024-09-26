using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_lez01_introduzione_mapping.Models;

public partial class DbLez02LibreriaContext : DbContext
{
    public DbLez02LibreriaContext()
    {
    }

    public DbLez02LibreriaContext(DbContextOptions<DbLez02LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=db_lez02_libreria;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libro__18C65F4BE4D76F33");

            entity.ToTable("Libro");

            entity.HasIndex(e => e.Isbn, "UQ__Libro__99F9D0A4234DD115").IsUnique();

            entity.Property(e => e.LibroId).HasColumnName("libroID");
            entity.Property(e => e.Autore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("autore");
            entity.Property(e => e.Editore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("N.D.")
                .HasColumnName("editore");
            entity.Property(e => e.Isbn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isbn");
            entity.Property(e => e.Pagine)
                .HasDefaultValue(1)
                .HasColumnName("pagine");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
