using AdvancedTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedTodo.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Todos.db");
        }
    }
}