using Microsoft.EntityFrameworkCore;

namespace Projeto.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) {
        }
        public DbSet<Usuario> Usuario {get; set;} 
    }
}