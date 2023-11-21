using ManyToManyEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyEF
{
    public class DataContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Staffs;Integrated Security=True;TrustServerCertificate=true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff()
                {
                    Id = 1,
                    Name = "Hr bo'limi"

                },
                new Staff()
                {
                    Id = 2,
                    Name = "Moliya bo'limi"
                },
                new Staff()
                {
                    Id = 3,
                    Name = "O'quv bo'limi"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Rustam",
                    StaffId = 1,
                },
                new User()
                {
                    Id = 2,
                    Name = "Dilmurod",
                    StaffId = 2
                },
                 new User()
                 {
                     Id = 3,
                     Name = "Sanjar",
                     StaffId = 2
                 }
                );

            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 1,
                Name = "O'tkan kunlar"
            },

            new Book()
            {
                Id = 2,
                Name = "Ikki eshik orasi"
            },
            new Book()
            {
                Id = 3,
                Name = "Chinor"
            });
        }
    }
}
