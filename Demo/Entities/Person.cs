using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal /*abstract*/ class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public int? Age { get; set; }
        public string? Address { get; set; }
    }
}
