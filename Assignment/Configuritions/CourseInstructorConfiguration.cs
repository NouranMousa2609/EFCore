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
    internal class CourseInstructorConfiguration:IEntityTypeConfiguration<CourseInstructor>
    {
        

        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.ToTable("CourseInstructor");
            builder.HasKey(SC => new { SC.InstructorId, SC.CourseId });
        }
    }
}
