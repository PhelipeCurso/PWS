using Microsoft.EntityFrameworkCore;
using PWS.Models;

namespace PWS.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) :base(options)
        {
        }
       
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Docentes> Docentes { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>().ToTable("Alunos");
            modelBuilder.Entity<Docentes>().ToTable("Docentes");
            modelBuilder.Entity<Instituicao>().ToTable("Instituicao");
            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
        }
    }
}
