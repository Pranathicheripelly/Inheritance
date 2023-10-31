using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ClassTeacher:Teacher
    {

        public string ClassResponsibility { get; set; }

        public ClassTeacher(string name, string department, string responsibility) : base(name, department)
        {
            ClassResponsibility = responsibility;
        }

    }
}
