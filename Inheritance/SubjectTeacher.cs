using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SubjectTeacher:Teacher

    {

        public string SubjectResponsibility { get; set; }

        public SubjectTeacher(string name, string department, string responsibility) : base(name, department)
        {
            SubjectResponsibility = responsibility;
        }

    }
}
