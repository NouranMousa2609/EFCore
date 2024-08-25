﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        //Navigational Property[many]
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public ICollection<StudentCourse> CourseStudents { get; set; } = new List<StudentCourse>();

    }
}