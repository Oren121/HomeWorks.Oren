using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class Student : Person
    {
        public Student() : base()
        {
            StudentId = 000;
            GradePointAverage = 0;
        }


        public Student(int id, double gradePointAverage, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            StudentId = id;
            GradePointAverage = gradePointAverage;
        }

        public int StudentId { get; set; }
        public double GradePointAverage { get; set; }
        public List<Course> CoursesList { get; set; } = new List<Course>();



        public override void DisplayInfo()
        {
            string Info = "Studnt Info:\n" +
                $"Full name: {FirstName} {LastName} \n" +
                $"Age: {Age}\n" +
                $"ID: {StudentId}\n" +
                $"Grade Average: {GradePointAverage}\n";
            Console.WriteLine(Info);

        }

    }
}
