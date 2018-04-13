namespace Sairi.ModuloAsistencia.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SairiContext : DbContext
    {
        public SairiContext()
            : base("name=SairiContext")
        {
        }

        public virtual DbSet<AsistenciaDocente> AsistenciaDocente { get; set; }
        public virtual DbSet<AsistenciaEstudiante> AsistenciaEstudiante { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docente>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.foto)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .HasMany(e => e.AsistenciaDocente)
                .WithRequired(e => e.Docente)
                .HasForeignKey(e => e.id_docente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.foto)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .HasMany(e => e.AsistenciaEstudiante)
                .WithRequired(e => e.Estudiante)
                .HasForeignKey(e => e.id_estudiante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Estudiante)
                .WithRequired(e => e.Nivel)
                .HasForeignKey(e => e.id_nivel)
                .WillCascadeOnDelete(false);
        }
    }
}
