using Microsoft.EntityFrameworkCore;

namespace TodoAPI
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TodoDatabase;Authentication=Active Directory Integrated;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasKey(x => x.Id);
            modelBuilder.Entity<TodoList>().HasKey(x => x.Id);
        }
    }
}
