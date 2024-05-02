using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
       public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Initial Catalog=SATKVITOR;Integrated Security=True;
            optionsBuilder.UseSqlite(connectionString:"Data Source=Banco.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
