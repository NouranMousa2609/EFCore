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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn(10, 10);
            builder.Property(e => e.Name)
                .IsRequired()  
                .HasMaxLength(100);

            builder.Property(e => e.Bouns)
                .HasColumnType("decimal(18,2)");
                

            builder.Property(e => e.Salary)
                .HasColumnType("decimal(18,2)");
                 

            builder.Property(e => e.Address)
                .HasMaxLength(200);

            builder.Property(e => e.HourRate)
                .HasColumnType("decimal(18,2)");



           
        }

        }
}

