using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configuritions
{
    internal class StudentConfigurition : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            
            builder.HasKey(e => e.Id);

            
            builder.Property(e => e.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(e => e.FName)
                .IsRequired()  
                .HasMaxLength(50); 

            builder.Property(e => e.LName)
                .IsRequired()  
                .HasMaxLength(50); 

            builder.Property(e => e.Address)
                .HasMaxLength(100); 

            builder.Property(e => e.Age)
                .HasDefaultValue(null);

            builder
                .HasMany(S => S.StudentCourses)
                .WithOne(/*SC=>SC.Student*/)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

        }
}

