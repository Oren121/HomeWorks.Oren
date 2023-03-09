using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.university_OOP
{
    public class Faculty : Person
    {
        public Faculty() : base()
        {
            FacultyId = 000;
            Department = "";
        }


        public Faculty(int facultyId, string department, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            FacultyId = facultyId;
            Department = department;
        }

        public int FacultyId { get; set; }
        public string Department { get; set; }

        public override void DisplayInfo()
        {
            string Info = "Faculty Info:\n" +
            $"Full name: {FirstName} {LastName} \n" +
            $"Age: {Age}\n" +
            $"ID: {FacultyId}\n" +
            $"Department: {Department}\n";
            Console.WriteLine(Info);
        }
    }
}
