using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.EFContext
{
    public class Context : DbContext
    {
        // ctor
        public Context(DbContextOptions<Context> options) : base (options)
        {
            
        }

        // Mapping Entites
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Drogaria> Drogarias { get; set; }
        public DbSet<ContatoDrogaria> ContatoDrogarias { get; set; }

        // Provider and ConnectionString
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=CampanhaInfopharma;User ID=sa;Password=master;Integrated Security=False");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Funcionario>().ToTable("Funcionario");
            modelBuilder.Entity<Drogaria>().ToTable("Drogaria");
            modelBuilder.Entity<ContatoDrogaria>().ToTable("ContatoDrogaria");

            modelBuilder.Entity<ContatoDrogaria>().Property(c => c.FuncionarioIdFk).HasColumnName("FuncionarioIdFk");

            base.OnModelCreating(modelBuilder);
        }
    }
}