using Microsoft.EntityFrameworkCore;
using StudentCRUDApp.Models;



    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;");
        } }

