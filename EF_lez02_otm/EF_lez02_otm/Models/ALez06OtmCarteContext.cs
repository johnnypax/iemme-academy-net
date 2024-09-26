using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_lez02_otm.Models;

public partial class ALez06OtmCarteContext : DbContext
{
    public ALez06OtmCarteContext()
    {
    }

    public ALez06OtmCarteContext(DbContextOptions<ALez06OtmCarteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cartum> Carta { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=a_lez06_otm_carte;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cartum>(entity =>
        {
            entity.HasKey(e => e.CartaId).HasName("PK__Carta__30780D4D79EE01C2");

            entity.HasIndex(e => e.Codice, "UQ__Carta__40F9C18BEB0B1722").IsUnique();

            entity.Property(e => e.CartaId).HasColumnName("cartaID");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Negozio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("negozio");
            entity.Property(e => e.PersonaRif).HasColumnName("personaRIF");

            entity.HasOne(d => d.PersonaRifNavigation).WithMany(p => p.Carta)
                .HasForeignKey(d => d.PersonaRif)
                .HasConstraintName("FK__Carta__personaRI__44FF419A");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK__Persona__54B758F55E14D2BE");

            entity.ToTable("Persona");

            entity.Property(e => e.PersonaId).HasColumnName("personaID");
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
