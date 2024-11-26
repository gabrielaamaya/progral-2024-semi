using Microsoft.EntityFrameworkCore;
using sistema_academico.Models;
using sistemas_academicas.models;
using System;

namespace sistemas_academicas.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definición de claves primarias
            modelBuilder.Entity<Alumno>().HasKey(e => e.idAlumno);
            modelBuilder.Entity<Docente>().HasKey(e => e.idDocente);
            modelBuilder.Entity<Matricula>().HasKey(e => e.idMatricula);

            // Relación de Matricula hacia Alumno (uno a muchos)
            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Alumno)
                .WithMany(a => a.matriculas)
                .HasForeignKey(m => m.idAlumnos)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
