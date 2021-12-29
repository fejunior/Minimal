using Microsoft.EntityFrameworkCore;

namespace Minimal.Data
{
    public class AppDbContext : DbContext
    {//representação do banco de dados em memoria
        //Representação da tabela
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=shared");
    }
}
