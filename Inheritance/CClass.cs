using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class CClass
    {

        public string ClassName { get; set; }
        public int Year { get; set; }

        public CClass(string className, int year)
        {
            ClassName = className;
            Year = year;
        }

    }
}
