using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace REST_04_EF_Videoteche.Models;

public partial class AEfLez04VideotecheContext : DbContext
{
    public AEfLez04VideotecheContext()
    {
    }

    public AEfLez04VideotecheContext(DbContextOptions<AEfLez04VideotecheContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Supporto> Supportos { get; set; }

    public virtual DbSet<Videoteca> Videotecas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=a_ef_lez04_videoteche;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Supporto>(entity =>
        {
            entity.HasKey(e => e.SupportoId).HasName("PK__Supporto__DDE7A497F509B087");

            entity.ToTable("Supporto");

            entity.Property(e => e.SupportoId).HasColumnName("supportoID");
            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Disponibilita)
                .HasDefaultValue(true)
                .HasColumnName("disponibilita");
            entity.Property(e => e.Tipo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
            entity.Property(e => e.VideotecaRif).HasColumnName("videotecaRIF");

            entity.HasOne(d => d.VideotecaRifNavigation).WithMany(p => p.Supportos)
                .HasForeignKey(d => d.VideotecaRif)
                .HasConstraintName("FK__Supporto__videot__29572725");
        });

        modelBuilder.Entity<Videoteca>(entity =>
        {
            entity.HasKey(e => e.VideotecaId).HasName("PK__Videotec__B44B70FFA8A19258");

            entity.ToTable("Videoteca");

            entity.Property(e => e.VideotecaId).HasColumnName("videotecaID");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
