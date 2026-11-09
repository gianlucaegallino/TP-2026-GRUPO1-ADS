using System;
using Entity.EFModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ModeloParcialContext : DbContext
{
    public ModeloParcialContext()
    {
    }

    public ModeloParcialContext(DbContextOptions<ModeloParcialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Equipo> Equipo { get; set; }

    public virtual DbSet<Jugador> Jugador { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Partido> Partido { get; set; }

    public virtual DbSet<Torneo> Torneo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Localhost;Initial Catalog=GestorTorneosEquipos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.IdEquipo).HasName("PK__Equipo__CD77B57F8F7A8F29");

            entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Fechafundacion).HasColumnName("FECHAFUNDACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Jugador>(entity =>
        {
            entity.HasKey(e => e.IdJugador).HasName("PK__Jugador__14B5F65956D3FF69");

            entity.Property(e => e.IdJugador).HasColumnName("ID_JUGADOR");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");
            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numerocamiseta).HasColumnName("NUMEROCAMISETA");

            entity.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.Jugador)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jugador__ID_EQUI__52593CB8");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Jugador)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jugador__ID_PAIS__534D60F1");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PK__Pais__B68D33A1551E2D09");

            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Partido>(entity =>
        {
            entity.HasKey(e => e.IdPartido).HasName("PK__Partido__BF59BB133F6EED37");

            entity.Property(e => e.IdPartido).HasColumnName("ID_PARTIDO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechafinpartido)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFINPARTIDO");
            entity.Property(e => e.Goleslocal).HasColumnName("GOLESLOCAL");
            entity.Property(e => e.Golesvisitante).HasColumnName("GOLESVISITANTE");
            entity.Property(e => e.IdEquipoLocal).HasColumnName("ID_EQUIPO_LOCAL");
            entity.Property(e => e.IdEquipoVisitante).HasColumnName("ID_EQUIPO_VISITANTE");
            entity.Property(e => e.IdTorneo).HasColumnName("ID_TORNEO");

            entity.HasOne(d => d.IdEquipoLocalNavigation).WithMany(p => p.PartidoIdEquipoLocalNavigation)
                .HasForeignKey(d => d.IdEquipoLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partido__ID_EQUI__5441852A");

            entity.HasOne(d => d.IdEquipoVisitanteNavigation).WithMany(p => p.PartidoIdEquipoVisitanteNavigation)
                .HasForeignKey(d => d.IdEquipoVisitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partido__ID_EQUI__5535A963");

            entity.HasOne(d => d.IdTorneoNavigation).WithMany(p => p.Partido)
                .HasForeignKey(d => d.IdTorneo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partido__ID_TORN__5629CD9C");
        });

        modelBuilder.Entity<Torneo>(entity =>
        {
            entity.HasKey(e => e.IdTorneo).HasName("PK__Torneo__FCCC9043C5D298A6");

            entity.Property(e => e.IdTorneo).HasColumnName("ID_TORNEO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
