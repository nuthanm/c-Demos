using Microsoft.EntityFrameworkCore;
using GenericsDemo.Models;

namespace GenericsDemo
{
    public class GenericsDemoDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>(); 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("GenericsDemoApp"); // Name of the inmemory database.
        }
    }
}