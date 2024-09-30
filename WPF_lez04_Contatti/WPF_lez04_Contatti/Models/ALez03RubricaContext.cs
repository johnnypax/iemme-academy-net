using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WPF_lez04_Contatti.Models;

public partial class ALez03RubricaContext : DbContext
{
    public ALez03RubricaContext()
    {
    }

    public ALez03RubricaContext(DbContextOptions<ALez03RubricaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contatto> Contattos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=a_lez03_rubrica;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contatto>(entity =>
        {
            entity.HasKey(e => e.ContattoId).HasName("PK__Contatto__29999534CB5B3929");

            entity.ToTable("Contatto");

            entity.HasIndex(e => e.Email, "UQ__Contatto__AB6E61648D41CD60").IsUnique();

            entity.HasIndex(e => e.CodFis, "UQ__Contatto__FFE8FD98C2D32F13").IsUnique();

            entity.Property(e => e.ContattoId).HasColumnName("contattoID");
            entity.Property(e => e.CodFis)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_fis");
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
