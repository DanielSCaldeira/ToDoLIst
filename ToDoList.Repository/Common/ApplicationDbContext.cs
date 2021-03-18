using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.Repository
{
    public class ApplicationDbContext : DbContext
    {
        //Toda a vez que é criado o modulo ele é chamado
        //Um DbSet representa uma coleção de entidades em memoria

        public virtual DbSet<Lista> Listas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Faz a chamada da Herança
            base.OnModelCreating(modelBuilder);

            //Carrega todo o mapiamento pelo Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public ApplicationDbContext()
        {
            //Almenta a performance sendo falso avisando para o entity não identificar a alteração.
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            //
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

    }
}
