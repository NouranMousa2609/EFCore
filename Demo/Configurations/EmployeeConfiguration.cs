using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
    {
        
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                 .Property<string>("Address")
                 .IsRequired(true)
                 .HasDefaultValue("Cairo");

            builder
             .HasOne(E => E.Department)
             .WithMany(D => D.Employees)
             .HasForeignKey("DepartmentId")
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
