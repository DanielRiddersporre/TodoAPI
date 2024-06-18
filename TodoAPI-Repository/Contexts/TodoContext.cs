using Microsoft.EntityFrameworkCore;

namespace SimpleTodo_Domain
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Move connection string to Github secrets
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TodoDatabase;Authentication=Active Directory Integrated;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasKey(x => x.Id);
            modelBuilder.Entity<TodoList>().HasKey(x => x.Id);
        }
    }
}
