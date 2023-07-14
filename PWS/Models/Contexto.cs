using Microsoft.EntityFrameworkCore;

namespace PWS.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) :base(options)
        {
        }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Docentes> Docentes { get; set; }
    }
}
