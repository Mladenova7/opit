using CatsApplication18.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatsApplication18.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Cat>cats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>().HasData(
                 new Cat { Id=1,Age = 2, Breed = "Angorska", Name = "Misho" },
                new Cat {Id=2, Age = 1, Breed = "Persian", Name = "Gogo" },
                new Cat { Id=3,Age = 4, Breed = "Siamska", Name = "Lily" }


            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
