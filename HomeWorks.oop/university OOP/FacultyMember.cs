using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class FacultyMember : Faculty, ITeachable
    {
        public double AssignGrades(Course course, Student student)
        {
            // assign a random grade between 0 and 4
            double grade = new Random().NextDouble() * 4;
            Console.WriteLine($"Assigned grade {grade:F2} to {student.FirstName} {student.LastName} in {course.CourseName}");
            return grade;
        }
        public void Teach(Course course)
        {
            Console.WriteLine($"Faculty member {FirstName} {LastName} is teaching {course.CourseName}");
        }
    }
}
