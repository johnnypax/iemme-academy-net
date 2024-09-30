using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_lez09_correzione_libreria.Models;

public partial class RecapLibrContext : DbContext
{
    public RecapLibrContext()
    {
    }

    public RecapLibrContext(DbContextOptions<RecapLibrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Prestito> Prestitos { get; set; }

    public virtual DbSet<Utente> Utentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=recap_libr;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libro__18C65CAB162CE3F2");

            entity.ToTable("Libro");

            entity.Property(e => e.LibroId).HasColumnName("libroId");
            entity.Property(e => e.AnnoPub).HasColumnName("annoPub");
            entity.Property(e => e.CodLibro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codLibro");
            entity.Property(e => e.StatoDis)
                .HasDefaultValue(true)
                .HasColumnName("statoDis");
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        modelBuilder.Entity<Prestito>(entity =>
        {
            entity.HasKey(e => e.PrestitoId).HasName("PK__Prestito__7E579A95FA9E52BC");

            entity.ToTable("Prestito");

            entity.Property(e => e.PrestitoId).HasColumnName("prestitoId");
            entity.Property(e => e.DataPres).HasColumnName("dataPres");
            entity.Property(e => e.DataRit).HasColumnName("dataRit");
            entity.Property(e => e.LibroRif).HasColumnName("libroRIF");
            entity.Property(e => e.UtenteRif).HasColumnName("utenteRIF");

            entity.HasOne(d => d.LibroRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.LibroRif)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Prestito__libroR__2E1BDC42");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.UtenteRif)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Prestito__utente__2D27B809");
        });

        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utente__CA5C22734A2272B1");

            entity.ToTable("Utente");

            entity.HasIndex(e => e.Email, "UQ__Utente__AB6E61649B258660").IsUnique();

            entity.Property(e => e.UtenteId).HasColumnName("utenteId");
            entity.Property(e => e.CodUtente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codUtente");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
