using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }

        //Navigational property [Many]
        //[InverseProperty (nameof(Department.Employees))]
        public ICollection <Employee>? Employees { get; set; } = new HashSet<Employee>();

        
    }
}
