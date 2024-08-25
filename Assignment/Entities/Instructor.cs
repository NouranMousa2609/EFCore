using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }

        public string? Address { get; set; }
        public decimal HourRate { get; set; }

        public int? DepartmentId { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department? ManageDepartment { get; set; } =null!;

        public Department? Department { get; set; } = null!;

        public ICollection<CourseInstructor> InstructorCourses { get; set; } = new List<CourseInstructor>();

    }
}
