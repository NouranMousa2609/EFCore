﻿using System;
using System.Collections.Generic;
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

    }
}
