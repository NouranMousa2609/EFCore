using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class InheritanceDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5P13SE6\\SQLEXPRESS;Database=Inheritance;Trusted_Connection=True;Encrypt=False ");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>()
                .Property(F => F.Salary)
                .HasColumnType("decimal(12,2)");
            
            modelBuilder.Entity<PartTimeEmployee>()
                .Property(P=>P.HourRate)
                .HasColumnType("decimal(12,2)");

            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Person>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Person>();

            modelBuilder.Entity<Person>().ToTable("Persons");
        }

        public DbSet<Person> Persons { get; set; }
    //    public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
    //    public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    //
    }
}
