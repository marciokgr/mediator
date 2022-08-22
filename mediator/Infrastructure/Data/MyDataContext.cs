using Microsoft.EntityFrameworkCore;
using mediator.Models;

namespace mediator.Infrastructure.Data
{
    public class MyDataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                   => options.UseSqlite("DataSource=app.db;Cache=Shared");

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
