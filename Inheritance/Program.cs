using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
  internal class program
    {
 
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            CClass cClass = new CClass("Math 101", 2023);

            ClassTeacher classTeacher = new ClassTeacher("Mr. Smith", "Math Department", "Class Management");

            SubjectTeacher subjectTeacher = new SubjectTeacher("Ms. Johnson", "Physics Department", "Physics Teaching");

            Console.WriteLine("Class Details:");
            Console.WriteLine($"Class Name: {cClass.ClassName}");
            Console.WriteLine($"Year: {cClass.Year}");
            Console.WriteLine("\nClass Teacher Details:");
            Console.WriteLine($"Name: {classTeacher.Name}");
            Console.WriteLine($"Department: {classTeacher.Department}");
            Console.WriteLine($"Responsibility: {classTeacher.ClassResponsibility}");
            Console.WriteLine("\nSubject Teacher Details:");
            Console.WriteLine($"Name: {subjectTeacher.Name}");
            Console.WriteLine($"Department: {subjectTeacher.Department}");
            Console.WriteLine($"Responsibility: {subjectTeacher.SubjectResponsibility}");
            Console.ReadLine();
        }
    }
}

