using dotnetProject2.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetProject2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}