using CommonEntities;
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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> E)
        {
            
                E.ToTable("Department", "dbo").HasKey(D => D.Id);
                E.Property(D => D.Id).UseIdentityColumn(10, 10);

                E.Property(D => D.Name)
                     .HasColumnName("DepartmentName")
                     .HasColumnType("varchar")
                     .HasMaxLength(50);
                //.HasAnnotation("MaxLength",50)
                //.HasAnnotation("",)
                //.HasAnnotation("",)
                //.HasAnnotation("",)
                //.HasAnnotation("",)



                E.Property(D => D.CreationDate)
                   .HasComputedColumnSql("GETDATE()");
                //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));
                //.HasColumnType("date")

          
        }
    }
}
