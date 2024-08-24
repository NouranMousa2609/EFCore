using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using CommonEntities;
using Demo.Configurations;
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



       // public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
           //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }

        //public DbSet<Department> Departments { get; set; }

    }
}
