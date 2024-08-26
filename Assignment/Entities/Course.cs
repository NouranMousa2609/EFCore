using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public ICollection<StudentCourse> CourseStudent { get; set; } = new List<StudentCourse>();
        public ICollection<CourseInstructor> Courseinstructors { get; set; } = new List<CourseInstructor>();

        public ICollection<Topic>? topics { get; set; } = new HashSet<Topic>();
    }
}
