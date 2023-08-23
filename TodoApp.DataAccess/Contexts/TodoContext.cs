using Microsoft.EntityFrameworkCore;
using TodoApp.DataAccess.Configurations;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.Contexts
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
        }
        public DbSet<Work> Works { get; set; }



    }
}
