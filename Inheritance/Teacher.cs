﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher
    {

        public string Name { get; set; }
        public string Department { get; set; }

        public Teacher(string name, string department)
        {
            Name = name;
            Department = department;
        }

    }
}
