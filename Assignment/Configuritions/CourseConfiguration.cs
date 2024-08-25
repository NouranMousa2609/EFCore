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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");

            
            builder.HasKey(e => e.Id);

            
            builder.Property(e => e.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(e => e.Name)
                .IsRequired()  
                .HasMaxLength(100); 

            builder.Property(e => e.Description)
                .HasMaxLength(500); 

            
            builder.Property(e => e.Duration)
                .IsRequired();

            builder
                .HasMany(c => c.CourseStudent)
                .WithOne(/*SC=>SC.Course*/)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
            
        
    }
}
