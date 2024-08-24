using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using CommonEntities;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        //public CompanyDbContext():base()
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Server=DESKTOP-5P13SE6\\SQLEXPRESS;Database=Company;Trusted_Connection=True;Encrypt=False ");



        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                  .Property("Address")
                  .HasDefaultValue("Cairo");
            modelBuilder.Entity<Department>().ToTable("Department", "dbo").HasKey(D => D.Id);
            modelBuilder.Entity<Department>().Property(D => D.Id).UseIdentityColumn(10, 10);

            modelBuilder.Entity<Department>()
                .Property(D => D.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .HasMaxLength(50);
            //.HasAnnotation("MaxLength",50)
            //.HasAnnotation("",)
            //.HasAnnotation("",)
            //.HasAnnotation("",)
            //.HasAnnotation("",)



            modelBuilder.Entity<Department>()
               .Property(D => D.CreationDate)
               .HasComputedColumnSql("GETDATE()");
            //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));
            //.HasColumnType("date")
        }

        public DbSet<Department> Departments { get; set; }

    }
}
