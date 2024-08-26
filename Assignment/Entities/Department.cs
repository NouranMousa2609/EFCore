using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Department
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;


        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();

        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor>? Instructors { get; set; } = new HashSet<Instructor>();
        public int? ManagerId { get; set; }

      
        [ForeignKey(nameof(ManagerId))]
        public Instructor? Manager { get; set; }
    }
}
