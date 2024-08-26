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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                 .HasMany(c => c.CourseStudents)
                 .WithOne(/*SC=>SC.Course*/)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
