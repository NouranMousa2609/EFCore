using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class PartTimeEmployee:Person
    {
        public decimal HourRate { get; set; }

        public int CountOfHours { get; set; }
     }
}
