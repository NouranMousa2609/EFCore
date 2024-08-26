using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }

        //Navigational Property[many]
        //public ICollection<Course> Courses { get; set; }=new HashSet<Course>();
        
        public ICollection<StudentCourse>StudentCourses { get; set; }= new List<StudentCourse>();
    
    
    
    }
}
